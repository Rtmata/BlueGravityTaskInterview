using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string demoLLevel;
    public void LoadGame()
    {
        SceneManager.LoadScene(demoLLevel, LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
