using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void RestartMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu(){
        SceneManager.LoadScene(1);
    }
    public void ReSetMenu(){
        PlayerPrefs.SetInt("SaveCash",00);
        PlayerPrefs.SetString("SaveName","Level0");
        SceneManager.LoadScene(1);
    }
    public void CreditsMenu(){
        SceneManager.LoadScene(2);
    } 
    public void HelpAbout(){
        SceneManager.LoadScene(17);
    }
    public void Back(){
        SceneManager.LoadScene(16);
    }
}
