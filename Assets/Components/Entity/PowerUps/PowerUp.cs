using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Poplloon.Entity
{
    public class PowerUp : EntityController
    {
        [Header("Identifier")]
        [SerializeField] private string _id;

        public string Id => _id;
        
        [Space]
        [Header("Texture Settings")]
        [SerializeField] private GameObject _model;
        [SerializeField] private Material _texture;

        [Space]
        [Header("Particle System")]
        [SerializeField] private ParticleSystem _main;

        internal override void EnableOnInstance()
        {
            gameObject.tag = "PowerUp";

            SetTexture(_texture);

            _isMoving = true;
        }

        public void SetTexture(Material texture)
        {
            Renderer _renderer = _model.GetComponent<Renderer>();

            _renderer.material = texture;
        }

        private IEnumerator DisableEntity()
        {
            _model.SetActive(false);

            gameObject.GetComponent<BoxCollider>().enabled = false;

            _main.Play();

            yield return new WaitForSeconds(2f);

            gameObject.GetComponent<BoxCollider>().enabled = true;

            _model.SetActive(true);

            Recycle();
        }
    }
}
