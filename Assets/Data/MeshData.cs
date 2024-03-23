using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Poplloon.Attributes
{   
    [System.Serializable]
    public class MeshSet
    {
        [SerializeField] private List<MeshData> _meshes = new List<MeshData>();
      
        public MeshData GetMeshData(int index)
        {
            return _meshes[index];
        }

        public void AddMeshData(MeshData _data)
        {
            _meshes.Add(_data);
        }

        public MeshData GetRandomMesh()
        {
            int i = UnityEngine.Random.Range(0, _meshes.Count);

            return _meshes[i];
        }
    }

    [System.Serializable]
    //Object as a dataset
    public class MeshData
    {
        public Mesh _mesh;
        public Material _material;
        public string _name;

        //Settings of dataset for instances
        public static void SetMeshData(Mesh mesh, Material material, Renderer renderer, MeshFilter filter)
        {
            renderer.material = material;
            filter.mesh = mesh;
        }

        public string GetName() => _name;
    }
}
