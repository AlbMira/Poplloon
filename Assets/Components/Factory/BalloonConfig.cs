using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Poplloon.Entity;

namespace Poplloon.Factory
{
    [CreateAssetMenu(menuName = "Custom/Balloon Configuration")]
    public class BalloonConfig : ScriptableObject
    {
        [SerializeField] private EntityController[] _balloons;
        private Dictionary<int, EntityController> _idOfBalloon;

        public EntityController[] Balloons => _balloons;

        private void Init()
        {
            _idOfBalloon = new Dictionary<int, EntityController>();

            foreach (var item in _balloons)
            {
                _idOfBalloon.Add(item.Index, item);
            }
        }

        public EntityController GetBalloonPrefabById(int index)
        {
            if (!_idOfBalloon.TryGetValue(index, out var _balloon))
            {
                throw new Exception($"Item with {index} does not exist.");
            }

            return _balloon;
        }
    }
}
