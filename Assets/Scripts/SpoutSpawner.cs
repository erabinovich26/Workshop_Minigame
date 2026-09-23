using UnityEngine;

public class SpoutSpawner : MonoBehaviour
{
    public GameObject[] spoutPrefabs;
    

    public float startDelay = 1;
    public float spawnInterval = 2;
    public float spawnHeight = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomSpout", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnRandomSpout()
    {
        int platformIndex = Random.Range(0, spoutPrefabs.Length);
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + spawnHeight, transform.position.z);

        Instantiate(spoutPrefabs[platformIndex], spawnPos, spoutPrefabs[platformIndex].transform.rotation);
        
    }
}
