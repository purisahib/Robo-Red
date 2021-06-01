using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBaseManager : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    public GameObject Level7;
    public GameObject Level8;
    public GameObject Level9;
    public GameObject Level10;

    public string LevelName;
    public GameObject CashDisplay;

    void Start()
    {
        updateFalse();
       LevelName=PlayerPrefs.GetString("SaveName");
       if (LevelName=="Level1")
       {
           update1();
       }
       if (LevelName=="Level2")
       {
           update2();
       }
       if (LevelName=="Level3")
       {
           update3();
       }
       if (LevelName=="Level4")
       {
           update4();
       }
       if (LevelName=="Level5")
       {
           update5();
       }
       if (LevelName=="Level6")
       {
           update6();
       }
       if (LevelName=="Level7")
       {
           update7();
       }
       if (LevelName=="Level8")
       {
           update8();
       }
       if (LevelName=="Level9")
       {
           update9();
       }

    }
    void Update()
    {
       // CashDisplay.GetComponent<Text>().text=""+TotalCash;
    }
    void updateFalse(){
        Level2.GetComponent<Button>().enabled=false;
        Level2.GetComponent<Image>().enabled=false;

        Level3.GetComponent<Button>().enabled=false;
        Level3.GetComponent<Image>().enabled=false;

        Level4.GetComponent<Button>().enabled=false;
        Level4.GetComponent<Image>().enabled=false;

        Level5.GetComponent<Button>().enabled=false;
        Level5.GetComponent<Image>().enabled=false;

        Level6.GetComponent<Button>().enabled=false;
        Level6.GetComponent<Image>().enabled=false;

        Level7.GetComponent<Button>().enabled=false;
        Level7.GetComponent<Image>().enabled=false;

        Level8.GetComponent<Button>().enabled=false;
        Level8.GetComponent<Image>().enabled=false;

        Level9.GetComponent<Button>().enabled=false;
        Level9.GetComponent<Image>().enabled=false;

        Level10.GetComponent<Button>().enabled=false;
        Level10.GetComponent<Image>().enabled=false;
    }
    void update1(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;
    }
    void update2(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;
    }
    void update3(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;
    }
    void update4(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;

        Level5.GetComponent<Button>().enabled=true;
        Level5.GetComponent<Image>().enabled=true;
    }
    void update5(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;

        Level5.GetComponent<Button>().enabled=true;
        Level5.GetComponent<Image>().enabled=true;

        Level6.GetComponent<Button>().enabled=true;
        Level6.GetComponent<Image>().enabled=true;
    }
    void update6(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;

        Level5.GetComponent<Button>().enabled=true;
        Level5.GetComponent<Image>().enabled=true;

        Level6.GetComponent<Button>().enabled=true;
        Level6.GetComponent<Image>().enabled=true;

        Level7.GetComponent<Button>().enabled=true;
        Level7.GetComponent<Image>().enabled=true;
    }
    void update7(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;

        Level5.GetComponent<Button>().enabled=true;
        Level5.GetComponent<Image>().enabled=true;

        Level6.GetComponent<Button>().enabled=true;
        Level6.GetComponent<Image>().enabled=true;

        Level7.GetComponent<Button>().enabled=true;
        Level7.GetComponent<Image>().enabled=true;

        Level8.GetComponent<Button>().enabled=true;
        Level8.GetComponent<Image>().enabled=true;
    }
    void update8(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;

        Level5.GetComponent<Button>().enabled=true;
        Level5.GetComponent<Image>().enabled=true;

        Level6.GetComponent<Button>().enabled=true;
        Level6.GetComponent<Image>().enabled=true;

        Level7.GetComponent<Button>().enabled=true;
        Level7.GetComponent<Image>().enabled=true;

        Level8.GetComponent<Button>().enabled=true;
        Level8.GetComponent<Image>().enabled=true;

        Level9.GetComponent<Button>().enabled=true;
        Level9.GetComponent<Image>().enabled=true;
    }
    void update9(){
        Level2.GetComponent<Button>().enabled=true;
        Level2.GetComponent<Image>().enabled=true;

        Level3.GetComponent<Button>().enabled=true;
        Level3.GetComponent<Image>().enabled=true;

        Level4.GetComponent<Button>().enabled=true;
        Level4.GetComponent<Image>().enabled=true;

        Level5.GetComponent<Button>().enabled=true;
        Level5.GetComponent<Image>().enabled=true;

        Level6.GetComponent<Button>().enabled=true;
        Level6.GetComponent<Image>().enabled=true;

        Level7.GetComponent<Button>().enabled=true;
        Level7.GetComponent<Image>().enabled=true;

        Level8.GetComponent<Button>().enabled=true;
        Level8.GetComponent<Image>().enabled=true;

        Level9.GetComponent<Button>().enabled=true;
        Level9.GetComponent<Image>().enabled=true;

        Level10.GetComponent<Button>().enabled=true;
        Level10.GetComponent<Image>().enabled=true;
    }
}
