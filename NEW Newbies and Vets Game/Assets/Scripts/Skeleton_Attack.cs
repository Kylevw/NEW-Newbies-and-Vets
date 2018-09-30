using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton_Attack : MonoBehaviour {

    public float attackDamage;

    public float knockbackDistance;
    public float knockbackHeight;

    public int hitTime;
    private int updateCount = 0;

    private GroundMonsterMovement movementControl;

    private SpriteRenderer spriteControl;

    private PlayerMovement hitPlayerMovement;

    private Color originalColor;

    private bool enemyHit = false;

	// Use this for initialization
	void Start () {

        movementControl = GetComponent<GroundMonsterMovement>();

	}
	
	// Update is called once per frame
	void Update () {

        if (enemyHit == true)
        {
            if (updateCount == hitTime)
            {
                spriteControl.color = originalColor;

                hitPlayerMovement.SetHitState(false);

                GetComponent<GroundMonsterMovement>().SetActiveState(true);

                hitPlayerMovement.resetVeloicty();

                enemyHit = false;
            }
            else
            {
                updateCount++;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            hitPlayerMovement = other.GetComponent<PlayerMovement>();

            if (hitPlayerMovement.getHitState() == false)
            {
                if (movementControl.getDirection().x < 0)
                {
                    other.GetComponent<Rigidbody2D>().velocity = new Vector2(-knockbackDistance, knockbackHeight);
                }
                else if (movementControl.getDirection().x > 0)
                {
                    other.GetComponent<Rigidbody2D>().velocity = new Vector2(knockbackDistance, knockbackHeight);
                }

                movementControl.SetActiveState(false);

                spriteControl = other.GetComponentInChildren<SpriteRenderer>();
                originalColor = spriteControl.color;
                spriteControl.color = Color.red;
                enemyHit = true;

                hitPlayerMovement.SetHitState(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        enemyHit = true;
    }
}
