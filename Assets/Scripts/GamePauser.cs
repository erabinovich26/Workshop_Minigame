using UnityEngine;
using UnityEngine.InputSystem;

public class GamePauser : MonoBehaviour
{
    public InputAction pause;
    public float pauseInput;
    public bool isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pause.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        pauseInput = pause.ReadValue<float>();
        
        if (pause.WasPressedThisFrame())
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;          
        isPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f;          
        isPaused = false;
    }
}
