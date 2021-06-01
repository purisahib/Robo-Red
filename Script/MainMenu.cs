using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string LevelName;
    
    public void MenuStart()
    {
        SceneManager.LoadScene(1);////SceneManager.GetActiveScene(). '1');//buildIndex+1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayGame()
    {
       LevelName=PlayerPrefs.GetString("SaveName");
       if (LevelName=="Level1")
       {
        SceneManager.LoadScene(6);
       }
       else if (LevelName=="Level2")
       {
           SceneManager.LoadScene(7);
       }
       else if (LevelName=="Level3")
       {
        SceneManager.LoadScene(8);
       }
       else if (LevelName=="Level4")
       {
           SceneManager.LoadScene(9);
       }
       else if (LevelName=="Level5")
       {
           SceneManager.LoadScene(10);
       }
       else if (LevelName=="Level6")
       {
           SceneManager.LoadScene(11);
       }
       else if (LevelName=="Level7")
       {
           SceneManager.LoadScene(12);
       }
       else if (LevelName=="Level8")
       {
           SceneManager.LoadScene(13);
       }
       else if (LevelName=="Level9")
       {
           SceneManager.LoadScene(14);
       }
       else
       {
           SceneManager.LoadScene(5);
       }

    }
}
