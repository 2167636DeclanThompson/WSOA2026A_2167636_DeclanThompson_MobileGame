using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Vector2 initialVelocity;
    public float maxSpeed = 10;
    public KeyCode Jump;
    public float JumpSpeed;
    public bool Grounded;
    public GameManager gameManager;
    public ScoreScript scoreScript;
    public GameObject Menu;

    private void Start()
    {
        Menu.SetActive(false);
    }

    private void Update()
    {
        
        if ((Input.GetKeyDown(Jump) || Input.touchCount > 0) && Grounded == true)
        {
            Grounded = false;
            Vector2 JumpForce = new Vector2(rigidBody.velocity.x, JumpSpeed);
            rigidBody.velocity = JumpForce;            
        }                
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Zombie")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Zombie(Clone)")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Cactus1")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Cactus1(Clone)")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Cactus2")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Cactus2(Clone)")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Cactus3")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        else if (collider.gameObject.name == "Cactus3(Clone)")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        
        Grounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Gem")
        {
            gameManager.PlayerScored(1);
        }   
        else if (collider.gameObject.name == "Gem(Clone)")
        {
            gameManager.PlayerScored(1);
        }

    }




}
