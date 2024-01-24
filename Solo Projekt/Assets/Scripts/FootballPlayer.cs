using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    [SerializeField] private int playerSpeed = 5;
    [SerializeField] private Transform gruondCheck;
    private Rigidbody2D rb;
    public void Run(float direction)
    {
        rb.velocity = new Vector2(direction * playerSpeed, rb.velocity.y);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        float ySpeed = rb.velocity.y;
       RaycastHit2D hit= Physics2D.Raycast(gruondCheck.position,Vector2.down,0.1f);
        
        if (Input.GetKeyDown(KeyCode.Space)&&hit.collider!=null)
        {
            ySpeed = 5;
        }
        Run(Input.GetAxis("Horizontal"));
    }
}
