﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScene : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneEnd());
    }

    IEnumerator SceneEnd(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1); 
    }
}
