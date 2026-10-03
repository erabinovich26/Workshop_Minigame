using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MainScreenController : MonoBehaviour
{
    public GameObject mainScreenUI; 
    public GameObject levelScreenUI;
    public TextMeshProUGUI myTextMeshPro;
    public static int Score;

    private void Start()
    {
        myTextMeshPro.text = ("Score: " + Score);
    }

    public void Levels()
    {
        levelScreenUI.SetActive(true);
        mainScreenUI.SetActive(false);
        //Debug.Log("transitioning 1");
    }

    public void Quit()
    {
        Application.Quit();  
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Back()
    {
        levelScreenUI.SetActive(false);
        mainScreenUI.SetActive(true);
        //Debug.Log("transitioning 2");
    }

    public void ScoreCount()
    {
        Score++; 
        myTextMeshPro.text = ("Score: " + Score); 
    }
}
