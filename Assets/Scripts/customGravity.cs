using System;
using UnityEngine;

public class customGravity : MonoBehaviour
{
    public float gravityScale = 2;
    private Rigidbody rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Physics.gravity *  gravityScale, ForceMode.Acceleration);
    }
}
