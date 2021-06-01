using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Out : MonoBehaviour
{
    public static int heart = 5;
    public int set=0;
    public GameObject PlayerObject;
    public AudioSource Player99;
    void Start()
    {
        heart=5;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (set==0)
        {
            if (other.tag == "Player")
            {
                 Player001();
                 Player99.Play();
                heart=heart-1;            
                if (heart==0)
                {
                   SceneManager.LoadScene(4);
                }
            }
        }    
    }
    void Player001(){
        set=1;
        PlayerObject.GetComponent<SpriteRenderer>().enabled=false;
        StartCoroutine(FirstSlape());        
    }
    IEnumerator FirstSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=true;
        StartCoroutine(SecondSlape());
    }
    IEnumerator SecondSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=false;
        StartCoroutine(ThirdSlape());
    }
    IEnumerator ThirdSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=true;
        StartCoroutine(FourSlape());
    }
    IEnumerator FourSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=false;
        StartCoroutine(FiveSlape());
    }
    IEnumerator FiveSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=true;
        StartCoroutine(SixSlape());
    }
    IEnumerator SixSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=false;
        StartCoroutine(SevenSlape());
    }
    IEnumerator SevenSlape(){
        yield return new WaitForSeconds(.3f);
        PlayerObject.GetComponent<SpriteRenderer>().enabled=true;
       // StartCoroutine(FourSlape());
       set=0;
    }
    
}
