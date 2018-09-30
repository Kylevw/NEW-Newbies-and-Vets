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

    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        defaultColor = sprite.color;
    }

    void Update () {

        transform.position += Vector3.up * Mathf.Sin(aliveTime) * displacement;
        aliveTime += Time.deltaTime * speed;

        sprite.color = Color.Lerp(defaultColor, pulseColor, Mathf.PingPong(pulseTime, 1));
        Debug.Log(Mathf.PingPong(pulseTime, 1));
        pulseTime += Time.deltaTime * pulseSpeed;

	}
}
