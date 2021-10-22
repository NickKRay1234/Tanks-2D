using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadLevel(int levelIndex)
    {
        if(levelIndex >= 0 && levelIndex <= SceneManager.sceneCountInBuildSettings)
        SceneManager.LoadScene(levelIndex);
        else
        {
            Debug.LogWarning("Error \t Script: GameManager, line 13");
        }
    }

    public void LoadLevel(string levelName)
    {
        if(Application.CanStreamedLevelBeLoaded(levelName))
        SceneManager.LoadScene(levelName);
        else
        {
            Debug.LogWarning("Error \t Script: GameManager, line 23");
        }
    }

    public void ReloadLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        LoadLevel(currentScene.buildIndex);
    }


}
