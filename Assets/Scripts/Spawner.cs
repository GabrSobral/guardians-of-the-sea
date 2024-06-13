using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn; // The prefab to be instantiated

    [SerializeField]
    private Vector2 screenBounds; // Bounds for the spawning area

    private void Start()
    {
        // Calculate screen bounds based on camera size
        Camera mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 1500, mainCamera.transform.position.z));

        for (int i = 0; i < 20; i++)
        {
            SpawnObject();
        }
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
