using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public InputAction movement;
    public Vector2 moveInput;
    public InputAction jumpInput;
    public float jumpForce;
    public float jumpSpeed;

    private Rigidbody rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;

    
    int currentWidth = Screen.width;
    int currentHeight = Screen.height;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        movement.Enable();
        jumpInput.Enable();
        

    }

  
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;

        jumpForce = jumpInput.ReadValue<float>();

        moveInput = movement.ReadValue<Vector2>();

            transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);

            transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * speed);

        if (IsGrounded())
        {
            Jump();
            //Debug.Log("grounded");
        }

        
    }

    private void FixedUpdate()
    {
        if (IsGrounded())
        {
            Jump();
            //Debug.Log("grounded");
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce * jumpSpeed, rb.linearVelocity.z);
        //rb.AddForce(0, 1 * jumpSpeed, 0);
    }
}
