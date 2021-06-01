using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print : MonoBehaviour
{
    public GameObject CoinText;
    public AudioSource CashSounds;
    public static int Coin=0;
    public static int TotalCoin;

    
    
    void Update(){
       CoinText.GetComponent<Text>().text=""+PlayerPrefs.GetInt("SaveCash");
    }
}
