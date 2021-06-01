using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{
    void Start(){
        //String string =SceneManager.GetActiveScene().name;
        Debug.Log(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetString("SaveName",SceneManager.GetActiveScene().name);
            PlayerPrefs.SetInt("SaveCash",CalculateCoin.TotalCoin);
            SceneManager.LoadScene(3);
        }
    }
}
