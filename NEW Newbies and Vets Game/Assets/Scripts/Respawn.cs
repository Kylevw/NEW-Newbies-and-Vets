using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    //put this script on the player

    public GameObject player;
    public GameObject ghost;
    public Vector2 ghostStartPos;

    public float maxResTime = 15f;
    public float minResTime = 1f;
    float resTime = 0f;

    float resHealth = 0f;

    bool canRes = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tombstone")
        {
            resTime = 0;
            canRes = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canRes = false;
        resTime = 0;
    }
    // Update is called once per frame
    void Update () {


        AllowRespawn();

    }


    void AllowRespawn()
    {

        if (canRes == true)
        {

            

            if (Input.GetKey("E"))
            {
                resTime += Time.deltaTime;

            }


            if (Input.GetKeyUp("E") && resTime < maxResTime && resTime >= minResTime)
            {
                resHealth = maxResTime / resTime;
                SpawnPlayer();
            }
            else if (resTime >= maxResTime)
            {
                resHealth = 1;
                SpawnPlayer();
            }

        }
    }

    void SpawnPlayer()
    {
        player.SetActive(true);
        //NEED TO SET PLAYER HEALTH TO MAX HEALTH * resHealth!!!!
        //
        //
        //
        ghost.transform.position = ghostStartPos;
        ghost.SetActive(false);

    }
}
