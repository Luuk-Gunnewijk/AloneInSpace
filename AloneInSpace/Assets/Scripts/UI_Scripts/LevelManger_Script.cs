using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger_Script : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("TestLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game");
    }
}
