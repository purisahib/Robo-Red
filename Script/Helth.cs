using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helth : MonoBehaviour
{
    public float Prograss=5;
    public Slider slider;
    void Update()
    {
        Prograss=Out.heart;
        slider.value=Prograss;
    }
}
