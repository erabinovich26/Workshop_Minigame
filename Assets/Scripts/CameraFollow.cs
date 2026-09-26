using UnityEngine;
using UnityEngine.Rendering;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 velocity;
    public Vector3 offset;
    public float smoothTime;
    public float maxSpeed = Mathf.Infinity;

    
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, smoothTime, maxSpeed);
        //Vector3 offset = new Vector3(transform.position.x - player.transform.position.x, transform.position.y - player.transform.position.y, transform.position.z - player.transform.position.z);
        Follow(player);

       
    }

    private void Follow(GameObject target)
    {
        transform.LookAt(target.transform);
    }
}
