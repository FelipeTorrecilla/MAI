using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] RangedAttacks;
    [SerializeField] private AudioClip fireballSound;


    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.X) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }


    private void Attack()
    {
        
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        RangedAttacks[FindRangedAttack()].transform.position = firePoint.position;
        RangedAttacks[FindRangedAttack()].GetComponent<Proyectile>().SetDirection(Mathf.Sign(transform.localScale.x));

   
    }
    private int FindRangedAttack()
    {
        for (int i = 0; i < RangedAttacks.Length; i++)
        {
            if(!RangedAttacks[i].activeInHierarchy)
                return i;
        }
        return 0;
    }

}
