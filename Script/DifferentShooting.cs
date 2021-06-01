using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifferentShooting : MonoBehaviour
{
        
    public  Transform firePoint;
    public  GameObject bulletPrefab;
    public  GameObject BullitText;
    public  AudioSource ButtonAudio;
    static GameObject bullet;

    public  AudioSource BulletSounds;
    public  int Gun1=15;
    int Gun2=10;
    int Gun3=8;  
    public static int Guns;

    //Extra for Fire Or Reload
    public static int FireBtnPoint=0;
    public static int ReloadGunBtnPoint=0;

    public  float bulletForce=20f;
    
     void Shoot(){
        BulletSounds.Play();
        bullet= Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb=bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    void Update(){
        if(FireBtnPoint==1){
            if (Gun1>=1)
            {
                Shoot();
                Gun1=Gun1-1;
               // BullitText.GetComponent<Text>().text=""+Gun1;  
            }
        }
        if (ReloadGunBtnPoint==1)
        {
            if(CalculateCoin.Coin>=20){
            ButtonAudio.Play();
            CalculateCoin.Coin=CalculateCoin.Coin-20;
            Gun1=10;
            //  BullitText.GetComponent<Text>().text=""+Gun1;    
            }
        }
        FireBtnPoint=0;
        ReloadGunBtnPoint=0;

        Guns=Gun1;
    }

}