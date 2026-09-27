using UnityEngine;

public class MoveForeward : MonoBehaviour
{
    public float speed;
    //public float moveAngle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Rotate(Vector3.up * moveAngle * Time.deltaTime, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
