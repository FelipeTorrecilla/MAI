using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInSeconds : MonoBehaviour
{
    [SerializeField] private float secondsToDestroy = 5f;
    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, secondsToDestroy);
    }

}
