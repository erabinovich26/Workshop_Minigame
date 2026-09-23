using UnityEngine;

public class OnWarningSpawn : MonoBehaviour
{
    public float waitTime = 2;
    public float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            Destroy(gameObject);
        }

    }
}
