using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_DIR_Switch : MonoBehaviour {

    public float playerID;

    public Sprite idleSprite;

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {

        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("P" + playerID + "_Move") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        else if  (Input.GetAxis("P" + playerID + "_Move") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        else if (Input.GetAxis("P" + playerID + "_Move") == 0)
        {
            spriteRenderer.sprite = idleSprite;
        }

	}
}
