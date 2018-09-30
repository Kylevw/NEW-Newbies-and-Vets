using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

    public float speed;

    private Transform player;
    private Vector2 target;

    public GameObject[] players;

    // Use this for initialization
    void Start () {

        //Check which player is closer
        players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length == 2)
        {
            if (Vector2.Distance(transform.position, players[0].transform.position) <= Vector2.Distance(transform.position, players[1].transform.position))
            {
                player = players[0].transform;
            }
            else if (Vector2.Distance(transform.position, players[0].transform.position) > Vector2.Distance(transform.position, players[1].transform.position))
            {
                player = players[1].transform;
            }
        }
        //else if(Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player1").transform.position) == Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player2").transform.position))
        //{
        //    closerPlayer = GameObject.FindGameObjectWithTag("Player1").transform;
        //}

        //Set target location
        target = new Vector2(player.position.x, player.position.y);
    }
    
    // Update is called once per frame
    void Update () {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
