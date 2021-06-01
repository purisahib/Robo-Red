using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject BullitText;
    public AudioSource ButtonAudio;

    public AudioSource BulletSounds;
    int Level5=20;
    int Level6=15;
    int Level7=10;
    int Level8=8;
    int Level9=20;
    int Level10=25;
    public int Levels;
    public int Scene;
   

    public float bulletForce=20f;

    void Update()
    {//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Scene=SceneManager.GetActiveScene().buildIndex;
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3"))
        {
            Fire(Scene);
        }
        if (Input.GetButtonDown("Reload1") || Input.GetButtonDown("Reload2") || Input.GetButtonDown("Reload3"))
        {
            ReloadGun();
        }
       
    }
    
    public void Fire(int Level){
       Levels=Level;
        if(Level==9){
            if (Level5>=1)
            {
                Shoot();
                Level5=Level5-1;
                BullitText.GetComponent<Text>().text=""+Level5;
            }

        }
        if(Level==10){
            if (Level6>=1)
            {
                Shoot();
                Level6=Level6-1;
                BullitText.GetComponent<Text>().text=""+Level6;
            }
        }
        if(Level==11){
            if (Level7>=1)
            {
                Shoot();
                Level7=Level7-1;
                BullitText.GetComponent<Text>().text=""+Level7;   
            }
        }
        if(Level==12){
            if (Level8>=1)
            {
                Shoot();
                Level8=Level8-1;
                BullitText.GetComponent<Text>().text=""+Level8;    
            }
        }
        if(Level==13){
            if (Level9>=1)
            {
                Shoot();
                Level9=Level9-1;
                BullitText.GetComponent<Text>().text=""+Level9;    
            }
        }
        if(Level==14){
            if (Level10>=1)
            {
                Shoot();
                Level10=Level10-1;
                BullitText.GetComponent<Text>().text=""+Level10;    
            }
        }
        
    }
    void Shoot(){
        BulletSounds.Play();
        GameObject bullet= Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb=bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    public void ReloadGun(){
        if(CalculateCoin.Coin>=40){
            ButtonAudio.Play();
        CalculateCoin.Coin=CalculateCoin.Coin-40;
        if(Levels==9){
            Level5=Level5+20;         
            BullitText.GetComponent<Text>().text=""+Level5;    
        }
        if(Levels==10){
            Level6=Level6+15;
            BullitText.GetComponent<Text>().text=""+Level6;    
        }
        if(Levels==11){
            Level7=Level7+10;
            BullitText.GetComponent<Text>().text=""+Level7;    
        }
        if(Levels==12){
            Level8=Level8+8;
            BullitText.GetComponent<Text>().text=""+Level8;    
        }
        if(Levels==13){
            Level9=Level9+20;
           BullitText.GetComponent<Text>().text=""+Level9;    
        }
        if(Levels==14){
            Level10=Level10+30;
            BullitText.GetComponent<Text>().text=""+Level10;    
        }
        
        }        
    }
}
