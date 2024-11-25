using UnityEngine;

public class FallingObjectSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab del objeto que cae// Referencia al sistema de actualización del NavMesh
    public float spawnInterval = 1f; // Intervalo entre la creación de objetos
    public Vector3 spawnArea = new Vector3(10f, 10f, 10f); // Área de generación
    public float spawnHeight = 15f; // Altura de generación

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnFallingObject();
            timer = 0f;
        }
    }

    void SpawnFallingObject()
    {
        // Generar posición aleatoria dentro del área definida
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
            spawnHeight,
            Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
        );

        // Crear el objeto
        GameObject cube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

        // Comprobar si ya tiene un Rigidbody, si no, añadirlo
        
        

        // Actualizar el NavMesh después de un retraso
        
    }


    
}
