using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioSource EnemySounds;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool enemy=collision.collider.GetComponent<Bullet>();
        if (enemy)
        {
            EnemySounds.Play();
            Destroy(gameObject);
        }
    }
}
