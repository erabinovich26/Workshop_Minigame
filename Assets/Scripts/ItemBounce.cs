using UnityEngine;

public class ItemBounce : MonoBehaviour
{
    public float time;
    public float yPos; 
    public float bounceSpeed;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * bounceSpeed;

        yPos = Mathf.Sin(time); 

        transform.Translate(Vector3.up * yPos * Time.deltaTime);
    }
}
