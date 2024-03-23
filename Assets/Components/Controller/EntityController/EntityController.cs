using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Utilities;
using Poplloon.Factory;


namespace Poplloon.Entity
{
    public abstract class EntityController : RecyclableObject
    {
        [SerializeField] private int _index;

        public int Index => _index;

        [Space]
        [Header("Offset variables")]
        [SerializeField] private float _offset;
        [SerializeField] private bool _enableOffset;

        [Space]
        [SerializeField] private float _speedMeter;

        [Space]
        [Header("Position variables")]
        [SerializeField] private float _zIndex;
        [SerializeField] private float _minScale;
        [SerializeField] private float _maxScale;
        [SerializeField] private float _minXPos;
        [SerializeField] private float _maxXPos;

        [Space]
        public bool _isMoving;

        private void Start()
        {
            _offset = UnityEngine.Random.Range(0f, 1f);
        }

        private void Update()
        {
            if(transform.position.y > 10f)
            {
                Recycle();
            }

            if (_isMoving == true)
            {
                Vector3 _dir = Vector3.up;
                float _speed = _speedMeter * Time.deltaTime;

                if (_enableOffset == true)
                {
                    transform.Translate(_dir * _speed + Vector3.right * (Mathf.Sin(Time.time + _offset) / 1200));
                }

                else { transform.Translate(_dir * _speed); }
            }
        }

        internal override void Init()
        {
            float xPos = Random.Range(_minXPos, _maxXPos);

            gameObject.transform.localScale = Vector3.one * Random.Range(_minScale, _maxScale);
            gameObject.transform.position = new Vector3(xPos, -10f, _zIndex);
            gameObject.SetActive(true);
        }

        internal override void Release()
        {
            Debug.Log($"{gameObject.tag} has been recycled");
        }
    }
}
