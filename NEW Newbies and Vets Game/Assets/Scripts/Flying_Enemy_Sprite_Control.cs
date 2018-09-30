using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying_Enemy_Sprite_Control : MonoBehaviour {

    public Sprite sprite_1;
    public Sprite sprite_2;
    public Sprite sprite_3;

    public int frameRate;

    private int updateCount;

    private SpriteRenderer spriteRenderer;

    private FlyingMonsterMovement movementController;

    // Use this for initialization
    void Start()
    {

        updateCount = 1;

        spriteRenderer = GetComponentInParent<SpriteRenderer>();

        movementController = GetComponentInParent<FlyingMonsterMovement>();


    }

    // Update is called once per frame
    void Update()
    {

        if (updateCount == frameRate)
        {
            updateCount++;
            spriteRenderer.sprite = sprite_1;
        }
        else if (updateCount == frameRate * 2)
        {
            updateCount++;
            spriteRenderer.sprite = sprite_2;
        }
        else if (updateCount == frameRate * 3)
        {
            updateCount = 1;
            spriteRenderer.sprite = sprite_3;
        }
        else
        {
            updateCount++;
        }

        if (movementController.getDirection() == "right")
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        else if (movementController.getDirection() == "left")
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

    }
}