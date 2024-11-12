using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BroScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool broIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && broIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > 3 || transform.position.y < -3)
        {
            logic.gameOver();
            broIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        broIsAlive = false;
    }
}
