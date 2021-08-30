using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //loads maingame or next game in the que when start game is selected 
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        //Quits application when Quit button is pressed with mouse
    }
}
