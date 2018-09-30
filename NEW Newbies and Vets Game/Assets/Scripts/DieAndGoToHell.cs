using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAndGoToHell : MonoBehaviour {



    public GameObject tombstone;
    public GameObject ghost;


    public int health;
    bool tombstoneSpawned;
    
	// Update is called once per frame
	void Update () {


        if (tombstone)
        {
            tombstoneSpawned = true;
        }


        if (health <= 0 && !tombstoneSpawned)
        {
            Instantiate(tombstone, this.transform.position, this.transform.rotation);

        }

	}



    void GoToHell()
    {
        gameObject.SetActive(false);
        ghost.SetActive(true);


    }
}
