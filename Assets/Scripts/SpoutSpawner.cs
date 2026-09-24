using UnityEngine;

public class SpoutSpawner : MonoBehaviour
{
    public GameObject[] spoutPrefabs;
    

    public float startDelay = 1;
    public float startOffset;
    public float spawnInterval = 2;
    public float spawnHeight = -15;
    
    void Start()
    {
        startOffset = Random.Range(4f, 20f) / 10f;
        InvokeRepeating("SpawnRandomSpout", startDelay + startOffset, spawnInterval);
    }
   
    void SpawnRandomSpout()
    {
        int platformIndex = Random.Range(0, spoutPrefabs.Length);
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + spawnHeight, transform.position.z);

        Instantiate(spoutPrefabs[platformIndex], spawnPos, spoutPrefabs[platformIndex].transform.rotation);
        
    }
}
