using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaKill : MonoBehaviour
{
    public Transform groundCheck;
    public Vector3 groundCheckDim;
    public LayerMask LavaLayer;
    public GameObject deathScreenUI;
    public static bool GameIsPaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInLava())
        {
            DeathScreen();
        }
    }

    private bool IsInLava()
    {
        return Physics.CheckBox(groundCheck.position, groundCheckDim, groundCheck.rotation, LavaLayer);
    }

    private void DeathScreen()
    {
        deathScreenUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void LoadMenu()

    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");

    }
}