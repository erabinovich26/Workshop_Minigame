using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaKill : MonoBehaviour
{
    public Transform groundCheck;
    public Vector3 groundCheckDim;
    public LayerMask LavaLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        groundCheckDim = new Vector3(1.1f, .1f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInLava())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private bool IsInLava()
    {
        return Physics.CheckBox(groundCheck.position, groundCheckDim, groundCheck.rotation, LavaLayer);
    }
}
