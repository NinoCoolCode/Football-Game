using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    [SerializeField] private float jumpSpeed = 7;
    [SerializeField] private int playerSpeed = 5;
    [SerializeField] private Transform groundCheck;

    protected bool hasRoboBall;
    protected bool canMove = true;

    private Rigidbody2D rb;
    private Vector3 startPosition;

    public void ActivatePowerUp(PowerUpType powerUpType)
    {

        switch (powerUpType)
        {
            case PowerUpType.RoboBall:
                hasRoboBall = true;
                break;
            case PowerUpType.FreezeEnemy:
                canMove = false;
                break;
            default:
                break;
        }
    }

    public void Reset()
    {
        transform.position = startPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
    }

    protected void Run(float direction)
    {
        if (canMove)
        {
            rb.velocity = new Vector2(direction * playerSpeed, rb.velocity.y);
        }
        
    }

      
    

    protected void Jump()
    {
        if (canMove)
        {
            float ySpeed = rb.velocity.y;
            RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, 0.1f);

            if (hit.collider != null)
            {
                ySpeed = jumpSpeed;
            }
            rb.velocity = new Vector2(rb.velocity.x, ySpeed);
        }
       
    }

    protected void InterruptJump()
    {
        if (rb.velocity.y>0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }

    protected void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }
}
