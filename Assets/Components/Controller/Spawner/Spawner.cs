using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Factory;
using Poplloon.Entity;

namespace Poplloon.Utilities
{
    public class Spawner : MonoBehaviour
    {
        [Header("Config factory and factory method")]
        [SerializeField] private BalloonConfig _balloonConfig;
        private BalloonFactory _balloonFactory;
        public bool _stopSpawning;

        private void Awake()
        {
            _balloonFactory = new BalloonFactory(Instantiate(_balloonConfig));

            InvokeRepeating(nameof(SpawnColor), 0f, 1f);
            InvokeRepeating(nameof(SpawnPower), 20f, 30f);
            InvokeRepeating(nameof(SpawnEnvironment), 0f, 2f);
        }

        private void Update()
        {
            if(_stopSpawning)
            {
                CancelInvoke();
            }
        }

        public void SpawnColor()
        {
            _balloonFactory.Create(0);
        }

        public void SpawnPower()
        {
            int index = Random.Range(1, 3);

            _balloonFactory.Create(index);
        }

        public void SpawnEnvironment()
        {
            _balloonFactory.Create(4);
        }
    }
}
