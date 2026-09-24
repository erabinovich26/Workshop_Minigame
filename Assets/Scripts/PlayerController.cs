using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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
    public Vector3 groundCheckDim;
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

        groundCheckDim = new Vector3(1.1f, .1f, 1.1f);
    }


    void Update()
    {
        //Vector2 mousePos = Input.mousePosition;

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
        return Physics.CheckBox(groundCheck.position, groundCheckDim, groundCheck.rotation, groundLayer);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce * jumpSpeed, rb.linearVelocity.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.SetParent(collision.transform);

            //Debug.Log("collided");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        transform.SetParent(null);

        //Debug.Log("exit collision");
    }

}
