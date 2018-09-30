using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    private float attackCooldown;
    private float attackTimer = 0.0f;
    public Transform attackPosition;
    public float attackRange;
    public int damage;
    public LayerMask playerLayer;
    public Transform player;
    public GameObject[] players;
    
    
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        if (Vector2.Distance(transform.position, players[0].transform.position) <= Vector2.Distance(transform.position, players[1].transform.position))
        {
            player = players[0].transform;
        }
        else if (Vector2.Distance(transform.position, players[0].transform.position) > Vector2.Distance(transform.position, players[1].transform.position))
        {
            player = players[1].transform;
        }
    }
    void Update()
    {
        if (attackTimer <= 0)
        {
            if(Vector2.Distance(transform.position, player.position)<attackRange){
                Collider2D[] damagedPlayers = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, playerLayer);
                for(int i = 0; i < damagedPlayers.Length; i++)
                {
                    damagedPlayers[i].GetComponent<FlyingMonsterMovement>().TakeDamage(damage);
                }
            }
            attackTimer = attackCooldown;
        }
        else
        {
            attackTimer -= Time.deltaTime;
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(attackPosition.position, attackRange);
         
    }

}