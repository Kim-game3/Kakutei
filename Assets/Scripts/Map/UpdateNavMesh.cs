using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class UpdateNavMesh : MonoBehaviour
{
    [SerializeField] NavMeshSurface _mapSurface;

    void Update()
    {
        _mapSurface.BuildNavMesh();
    }
}
