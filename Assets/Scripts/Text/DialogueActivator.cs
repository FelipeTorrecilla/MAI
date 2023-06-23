using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{
    private Animator anim;
    private Dialogue dialogue;
    public GameObject DialogueOption;
    

      void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            DialogueOption.SetActive(true);
        }
        
    }
}
