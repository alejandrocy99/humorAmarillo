using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
// Referencia al sistema de actualización del NavMesh
    public Vector3 rotationAxis = Vector3.up; // Eje de rotación
    public float rotationSpeed = 50f; // Velocidad de rotación (grados por segundo)

    void Update()
    {
        // Rotar la plataforma
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, Space.Self);

        // Actualizar el NavMesh después del giro
    }
}
