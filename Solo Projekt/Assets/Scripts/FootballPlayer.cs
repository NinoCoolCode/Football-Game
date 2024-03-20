using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    [SerializeField]private float jumpSpeed = 7;
   [SerializeField] private int playerSpeed = 5;
    [SerializeField] private Transform gruondCheck;
 
    private Rigidbody2D rb;
    private Vector3 startPosition;

    public void Reset()
    {
        transform.position = startPosition;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
    }
    public void Run(float direction)
    {
        rb.velocity = new Vector2(direction * playerSpeed, rb.velocity.y);
    }
    // Start is called before the first frame update
    public void Jump()
    {
       float ySpeed = rb.velocity.y;
        RaycastHit2D hit = Physics2D.Raycast(gruondCheck.position, Vector2.down, 0.1f);

        if (  hit.collider != null)
        {
            ySpeed = jumpSpeed;
        }
        rb.velocity = new Vector2( rb.velocity.x,ySpeed);
    }
    public void InteruptJump()
    {
        if (rb.velocity.y>0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
       
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {
        
       
     
    }
}
