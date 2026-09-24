using Unity.VisualScripting;
using UnityEngine;

public class OnSpoutSpawn : MonoBehaviour
{
    public GameObject warning;

    public float spoutSpeed;
    private bool reachedMax = false;
    public float maxHeight;
    public float minHeight;
    public float warningSpawnHeight = -1.09f;

    public float waitTime = 2;
    public float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, warningSpawnHeight, transform.position.z);
        Instantiate(warning, spawnPos, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            ActivateMovement();
        }

    }

    void ActivateMovement()
    {
        if (transform.position.y < maxHeight && reachedMax != true)
        {
            transform.Translate(0, 1 * Time.deltaTime * spoutSpeed, 0);
        }

        else if (transform.position.y > maxHeight)
        {
            reachedMax = true;
        }

        if (reachedMax == true)
        {
            transform.Translate(0, -1 * Time.deltaTime * spoutSpeed, 0);
        }

        if (transform.position.y < minHeight)
        {
            Destroy(gameObject);
        }
    }
}
