using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;
using Poplloon.Entity;

namespace Poplloon.Utilities
{
    public class ObjectPool
    {
        private readonly RecyclableObject _prefab;
        private readonly HashSet<RecyclableObject> _instantiateObjects;
        private Queue<RecyclableObject> _recycledObjects;
        public int entityCount;

        public ObjectPool(RecyclableObject prefab)
        {
            _prefab = prefab;
            _instantiateObjects = new HashSet<RecyclableObject>();
        }

        public void Init(int initialAmount)
        {
            _recycledObjects = new Queue<RecyclableObject>(initialAmount);

            for(int i = 0; i < initialAmount; i++)
            {
                var _instance = InstantiateNewInstance();
                _instance.gameObject.SetActive(false);

                _recycledObjects.Enqueue(_instance);
            }
        }

        private RecyclableObject InstantiateNewInstance()
        {
            var _instance = Object.Instantiate(_prefab);
            _instance.Configure(this);

            return _instance;
        }

        public T Spawning<T>()
        {
            var _recyclableObject = GetInstance();
            _instantiateObjects.Add(_recyclableObject);

            _recyclableObject.gameObject.SetActive(true);
            _recyclableObject.Init();
            _recyclableObject.EnableOnInstance();
            entityCount++;

            return _recyclableObject.GetComponent<T>();
        }

        private RecyclableObject GetInstance()
        {
            if(_recycledObjects.Count > 0)
            {
                return _recycledObjects.Dequeue();
            }

            Debug.LogWarning($"Not enough recycled objects {_prefab.name}");

            var _instance = InstantiateNewInstance();
           
            return _instance;
        }

        public void RecyclableGameObject(RecyclableObject obj)
        {
            var _instantiated = _instantiateObjects.Remove(obj);

            Assert.IsTrue(_instantiated, $"{obj.name} was not instantiated");

            obj.gameObject.SetActive(false);
            obj.Release();
            _recycledObjects.Enqueue(obj);
            entityCount--;
        }
    }
}
