using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textPrompt : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject floatingIndicator;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            floatingIndicator.SetActive(true);
            gameObject.SetActive(false);        
        }
    }
}