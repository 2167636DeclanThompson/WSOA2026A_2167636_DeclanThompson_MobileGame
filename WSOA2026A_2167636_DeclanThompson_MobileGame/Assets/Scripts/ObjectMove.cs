using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    private GameManager gameManager;
    public Rigidbody2D rigidBody;
    public Vector2 initialVelocity;
    public float maxSpeed = 10;

    private void Start()
    {
        
    }

    private void Update()
    {
        rigidBody.velocity = initialVelocity * maxSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
