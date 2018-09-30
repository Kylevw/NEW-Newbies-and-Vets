using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_DIR_Switch : MonoBehaviour {

    public float playerID;

    public Sprite idleSprite;

    public Sprite moveSprite_1;
    public Sprite moveSprite_2;
    public Sprite moveSprite_3;

    private SpriteRenderer spriteRenderer;

    private int updateCount = 1;

    public int frameRate;

	// Use this for initialization
	void Start () {

        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        if(updateCount == frameRate)
        {
            spriteRenderer.sprite = moveSprite_1;
            updateCount++;
        }
        else if(updateCount == frameRate * 2)
        {
            spriteRenderer.sprite = moveSprite_2;
            updateCount++;
        }
        else if(updateCount == frameRate * 3)
        {
            spriteRenderer.sprite = moveSprite_3;
            updateCount = 1;
        }
        else
        {
            updateCount++;
        }

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
