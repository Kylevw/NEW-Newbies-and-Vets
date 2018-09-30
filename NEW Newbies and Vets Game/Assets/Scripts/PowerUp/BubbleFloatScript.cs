using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleFloatScript : MonoBehaviour {

    public float speed;
    public float displacement;
    float aliveTime;

    SpriteRenderer sprite;
    Color defaultColor;

    public Color pulseColor;
    public float pulseSpeed;
    float pulseTime;

    public float spawnTime;
    public float aliveTimeMin;
    public float aliveTimeMax;

    float timeToDespawn;

    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        defaultColor = sprite.color;

        timeToDespawn = (Random.value * (aliveTimeMax - aliveTimeMin)) + aliveTimeMin;
    }

    void Update () {



        transform.position += Vector3.up * Mathf.Sin(aliveTime * speed) * displacement;
        aliveTime += Time.deltaTime;

        sprite.color = Color.Lerp(defaultColor, pulseColor, Mathf.PingPong(pulseTime, 1));
        pulseTime += Time.deltaTime * pulseSpeed;

        if (aliveTime >= timeToDespawn) {
            
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, transform.localScale.x * spawnTime);
            if (transform.localScale.x < 0.1f) {
                Destroy(gameObject);
            }

        } else {
            
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), (1 - transform.localScale.x) * spawnTime);

        }

	}
}
