using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Poplloon.Utilities;
using Poplloon.Entity;

namespace Poplloon.Factory
{
    public class BalloonFactory
    {
        private readonly BalloonConfig _balloonConfig;
        private Dictionary<int, ObjectPool> _pools;
        public int entityCount;

        public BalloonFactory(BalloonConfig balloonConfig)
        {
            _pools = new Dictionary<int, ObjectPool>();
            _balloonConfig = balloonConfig;

            var _balloons = _balloonConfig.Balloons;

            foreach(var item in _balloons)
            {
                var _objectPool = new ObjectPool(item);
                _objectPool.Init(15);
                _pools.Add(item.Index, _objectPool);
            }
        }

        public EntityController Create(int index)
        {
            var _objectPool = _pools[index];

            return _objectPool.Spawning<EntityController>();
        }
    }
}
