using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Poplloon.Utilities
{
    public abstract class RecyclableObject : MonoBehaviour
    {
        private ObjectPool _objectPool;
        
        internal void Configure(ObjectPool objectPool)
        {
            _objectPool = objectPool;
        }

        public void Recycle()
        {
            _objectPool.RecyclableGameObject(this);
        }

        internal abstract void Init();
        internal abstract void Release();
        internal abstract void EnableOnInstance();
    }
}

