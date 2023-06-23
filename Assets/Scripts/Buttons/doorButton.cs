using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorButton : MonoBehaviour
{
    private Animator anim;
    public GameObject doorDissappear;
    public GameObject doorAppear;
    [SerializeField] private GameObject floatingIndicator;
    


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorDissappear.SetActive(false);
            doorAppear.SetActive(true);
            gameObject.SetActive(false);        
        
        if(floatingIndicator)
        {
            floatingIndicator.SetActive(true);
        }
        }
    }
}
