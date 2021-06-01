using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
          if (other.tag == "Bullet")
        {
            //EnemySounds.Play();
            Destroy(gameObject);
        }
    }
}
