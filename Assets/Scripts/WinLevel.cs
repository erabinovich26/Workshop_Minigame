using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject WinScreenUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        WinScreen();
    }

    public void WinScreen()
    {
        WinScreenUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        //Destroy(gameObject);
    }

    public void Restart()
    {
        //Debug.Log("restarting");
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        //Debug.Log("loading menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");

    }
}
