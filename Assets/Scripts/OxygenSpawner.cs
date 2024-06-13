using UnityEngine;

public class OxygenSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn; // The prefab to be instantiated

    [SerializeField]
    private Vector2 screenBounds; // Bounds for the spawning area

    [SerializeField]
    private float spawnInterval = 7f;

    private void Start()
    {
        Camera mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 1500, mainCamera.transform.position.z));

        InvokeRepeating("SpawnObject", 0f, spawnInterval); // Start the spawning process
    }

    private void SpawnObject()
    {
        // Generate a random position within the screen bounds
        float randomX = Random.Range(-screenBounds.x, screenBounds.x);
        float randomY = Random.Range(-screenBounds.y, screenBounds.y);
        Vector2 randomPosition = new(randomX, randomY);

        // Instantiate the object at the random position
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}
