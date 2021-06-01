using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{
    public AudioSource ButtonAudio;

    public void Credits(){
        ButtonAudio.Play();
        SceneManager.LoadScene(2);
    }
    public void Restart(int Level){
        ButtonAudio.Play();
        SceneManager.LoadScene(Level);
    }
    public void ReSet(){
        ButtonAudio.Play();
        PlayerPrefs.SetInt("SaveCash",00);
        PlayerPrefs.SetString("SaveName","Level0");
        SceneManager.LoadScene(1);
    }
    public void Level(int Level){
        ButtonAudio.Play();
        SceneManager.LoadScene(Level);
    }
   
    public void Quit(){
        ButtonAudio.Play();
        Application.Quit();
    }
}