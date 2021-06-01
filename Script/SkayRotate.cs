using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkayRotate : MonoBehaviour
{
    public float rotatSpeed=0.5f;
    
    // Update is called once per frame
    void Update()
    {
      RenderSettings.skybox.SetFloat("_Rotation",rotatSpeed*Time.time);  
    }
}
