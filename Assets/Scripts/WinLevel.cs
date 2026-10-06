using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject WinScreenUI;
    public static bool isLevelThreeComplete = false;
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
        GetComponent<MeshRenderer>().enabled = false;

        if (gameObject.CompareTag("BananaWin1"))
        {
            BananaManager.isLevelOneComplete = true;
        }
        if (gameObject.CompareTag("BananaWin2"))
        {
            BananaManager.isLevelTwoComplete = true;
        }
        if (gameObject.CompareTag("BananaWin3"))
        {
            BananaManager.isLevelThreeComplete = true;
        }
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
