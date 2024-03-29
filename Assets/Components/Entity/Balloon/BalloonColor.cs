using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Factory;
using Poplloon.Attributes;
using Poplloon.Audio;

namespace Poplloon.Entity
{
    public class BalloonColor : EntityController
    {
        [Header ("GameObject to change")]
        [SerializeField] private GameObject _model;
        [SerializeField] private GameObject _tail;
        [SerializeField] private GameObject _teddy;

        [Space]
        public Color color;

        [Space]
        [Header("Particle System")]
        [SerializeField] private ParticleSystem _main;

        [Space]
        [Header("Teddy parameters")]
        [SerializeField] private Transform _parent;
        [SerializeField] private Rigidbody _rbTeddy;
        private bool _isTeddy;
      

        internal override void EnableOnInstance()
        {
            if(GameManager.Instance.changeInstanceColor > 0f)
            {
                SetColor(GameManager.Instance.currentColor);
            }

            else
            {
                SetColor(GameManager.Instance._colorBlind.GetColor());
                GameManager.Instance.changeInstanceColor += 5f;
            }

            SetTail(GameManager.Instance._tailSet.GetRandomMesh());
            SetTeddy(GameManager.Instance._teddySet.GetRandomMesh());

            _isMoving = true;
            _model.SetActive(true);
            _rbTeddy.isKinematic = true;
        }

        public void SetColor(Color colorData)
        {
            _model.transform.GetChild(0).GetComponent<Renderer>().material.color = colorData;

            color = colorData;
        }

        public void SetTail(MeshData data)
        {
            MeshData.SetMeshData(data._mesh, data._material, _tail.GetComponent<Renderer>(), _tail.GetComponent<MeshFilter>());

            if(data.GetName() == "Ribbon")
            {
                _teddy.SetActive(true);
                _isTeddy = true;
            }

            else { _teddy.SetActive(false); }
        }

        public void SetTeddy(MeshData data)
        {
            MeshData.SetMeshData(data._mesh, data._material, _teddy.GetComponent<Renderer>(), _teddy.GetComponent<MeshFilter>());
        }

        public void ParticleColor()
        {
            var main = _main.main;

            _main.Play();

            main.startColor = color;
        }

        private IEnumerator DisableEntity()
        {
            _model.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;

            AudioManager.Instance.PlayClip(0);

            if(_isTeddy)
            {
                AudioManager.Instance.PlayClip(1);
            }

            _main.Play();
            _teddy.transform.SetParent(null);
            _rbTeddy.isKinematic = false;
            _rbTeddy.angularVelocity = new Vector3(1f, 0f, 1f);

            yield return new WaitForSeconds(2f);

            gameObject.GetComponent<BoxCollider>().enabled = true;

            _teddy.transform.localPosition = Vector3.zero;
            _teddy.transform.localRotation = Quaternion.identity;
            _teddy.transform.localScale = Vector3.one;
            _teddy.transform.SetParent(_parent, false);
            _rbTeddy.angularVelocity = Vector3.zero;
            _rbTeddy.isKinematic = true;

            Recycle();
        }
    }
}
