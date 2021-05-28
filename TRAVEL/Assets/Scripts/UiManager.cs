using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

    public GameObject optionsPanel;

    public void OptionsPanel()
    {
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Retunr()
    {
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    } 
    
    public void AnotherOptions()
    {
        //Sonidos
        //Graficos
    }

    public void GoMainMenu()//Regresar al menu principal
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
