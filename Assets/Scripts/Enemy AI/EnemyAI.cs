using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
 [SerializeField] private float damage;
 [SerializeField] public float health, maxHealth = 3f;

 
    private Animator anim;

    

 private void Awake()
 {
    health = maxHealth;
    anim = GetComponent<Animator>();
 }

private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
public void TakeDamage(float damageAmount)
{
    health -= damageAmount;
    anim.SetTrigger("hurt");

    if(health <= 0)
        {
            anim.SetTrigger("die");
        }
}
public void EnemyDeath()
{
    gameObject.SetActive(false);
}
}
