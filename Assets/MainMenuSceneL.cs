using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneL : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");

    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Level");
    }
    public void LoadCredit()
    {
        SceneManager.LoadScene("CreditScroller");
    }
    public void LoadStart()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
