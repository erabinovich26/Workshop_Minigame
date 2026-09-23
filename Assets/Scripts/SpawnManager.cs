using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;

    public float startDelay = 0; 
    public float spawnInterval = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomPlatform", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomPlatform()
    {
        int platformIndex = Random.Range(0, platformPrefabs.Length);
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Instantiate(platformPrefabs[platformIndex], spawnPos, platformPrefabs[platformIndex].transform.rotation);
    }
}
