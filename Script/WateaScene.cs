using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WateaScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SplashSceneEnd());
    }

    IEnumerator SplashSceneEnd(){
        yield return new WaitForSeconds(13.2f);
        SceneManager.LoadScene(16); 
    }

}
