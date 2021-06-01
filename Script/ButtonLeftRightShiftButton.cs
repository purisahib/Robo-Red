using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeftRightShiftButton : MonoBehaviour
{
    public GameObject GameLevelButton1;
    public GameObject GameLevelButton2;
    public GameObject GameLevelButton3;
    public AudioSource ButtonAudio;
    public AudioSource Sound;

    public GameObject LeftShiftLevelButton;
    public GameObject RightShiftLevelButton;
    public int IncreaseDecreaseValue=0;
    public void LeftShiftButton(){
        IncreaseDecreaseValue=IncreaseDecreaseValue-1;
        ButtonAudio.Play();   
        Sound.Play();      
    }
    public void RightShiftButton(){
        IncreaseDecreaseValue=IncreaseDecreaseValue+1;
        ButtonAudio.Play();
        Sound.Play(); 
    }
    void Update(){
        if (IncreaseDecreaseValue==0)
        {
            LeftShiftLevelButton.SetActive(false);
            GameLevelButton1.SetActive(true);
            GameLevelButton2.SetActive(false);
        }
        if (IncreaseDecreaseValue==1)
        {
            RightShiftLevelButton.SetActive(true);
            LeftShiftLevelButton.SetActive(true);

            GameLevelButton2.SetActive(true);
            GameLevelButton1.SetActive(false);
            GameLevelButton3.SetActive(false);
        }
        if (IncreaseDecreaseValue==2)
        {
            RightShiftLevelButton.SetActive(false);
            
            GameLevelButton3.SetActive(true);
            GameLevelButton2.SetActive(false);
            LeftShiftLevelButton.SetActive(true);
            RightShiftLevelButton.SetActive(false);
        }
    }
}
