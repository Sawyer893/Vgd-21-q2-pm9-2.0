﻿using System.Collections;
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
}
