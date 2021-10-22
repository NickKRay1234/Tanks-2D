using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private GameObject settingsPanel;


   public void PlayGame()
   {
       SceneManager.LoadScene("Main");
   }

   public void ExitGame()
   {
       Application.Quit();
   }

   public void SettingsPanel()
   {
       SceneManager.LoadScene("Settings");
   }

   public void Exit()
   {
       settingsPanel.SetActive(false);
   }

   public void PauseGame()
   {
       SceneManager.LoadScene("PauseMenu");
   }



}
