using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float zBounds = -20;
    public float rightBounds = 30;
    public float leftBounds = -30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < zBounds)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBounds)
        {
            Destroy(gameObject);
        }
    }
}
