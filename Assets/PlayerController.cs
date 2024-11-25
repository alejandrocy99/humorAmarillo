using UnityEngine;
using UnityEngine.AI;

public class MoveWithClick : MonoBehaviour
{
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Ajustar la posición inicial del jugador al NavMesh
        if (NavMesh.SamplePosition(transform.position, out NavMeshHit hit, 10.0f, NavMesh.AllAreas))
        {
            agent.Warp(hit.position); // Coloca al jugador en el NavMesh
        }
        else
        {
            Debug.LogWarning("El jugador está fuera del NavMesh.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
