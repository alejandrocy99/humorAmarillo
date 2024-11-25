using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class DynamicNavMeshUpdater : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;

    public void UpdateNavMesh(){
        navMeshSurface.BuildNavMesh();
    }
}
