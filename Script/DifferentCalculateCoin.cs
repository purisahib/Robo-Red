using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentCalculateCoin : MonoBehaviour
{
   // public GameObject CoinText;
    public AudioSource CashSounds;
    public static int Coin=0;
    public static int TotalCoin;

    void Start(){
        Coin=PlayerPrefs.GetInt("SaveCash");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
          if (other.tag == "Coin")
        {
            
            CashSounds.Play();
           // Destroy(gameObject);
            update();
        }
    } 
    void update(){
        Coin=Coin+1;
        TotalCoin=Coin;
       // CoinText.GetComponent<Text>().text=""+TotalCoin;
    }
}
