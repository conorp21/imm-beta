using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy; // The object to respawn
    public int initialRespawnCount = 2; // Initial number of objects to respawn
    public int respawnIncrement = 2; // Number of objects to increment by when respawning

    // Update is called once per frame
    void Update()
    {
        // Check if the object count is zero
        if (ObjectCount() == 0)
        {
            // Respawn an increasing number of objects
            RespawnObjects();
        }
    }

    int ObjectCount()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(enemy.tag);
        return objects.Length;
    }

    void RespawnObjects()
    {
        int respawnCount = initialRespawnCount + (respawnIncrement * ObjectCount());

        Vector3 spawnPosition = GetRandomSpawnPosition();

        for (int i = 0; i < respawnCount; i++)
        {
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        // Replace this with your desired spawn position logic
        // For example, you can use Random.Range to specify a range of spawn positions
        float spawnX = -14;
        float spawnY = 1.5f;
        float spawnZ = Random.Range(0.5f, 4f);
        return new Vector3(spawnX, spawnY, spawnZ);
    }
}
