using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Script{

public class NewScriptAssineText : MonoBehaviour
{
    public GameObject BullitText;
    public GameObject CoinText;
    // Update is called once per frame
    void Update()
    {
        BullitText.GetComponent<Text>().text=""+DifferentShooting.Guns;
        CoinText.GetComponent<Text>().text=""+DifferentCalculateCoin.TotalCoin;
    }
    public void FireBtn(){
        DifferentShooting.FireBtnPoint=1;
    }
    public void ReloadBtn(){
        DifferentShooting.ReloadGunBtnPoint=1;
    }
}}
