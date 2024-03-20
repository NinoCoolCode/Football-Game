using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private int playerNumber = 1;
    [SerializeField] private Ball ball;
     private bool hasRoboBall;
    public void ActivatePowerUp()
    {
        hasRoboBall = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<FootballPlayer>().Run(Input.GetAxis("Horizontal" + playerNumber));
        
        if (hasRoboBall)
        {
            ball.SetVelocity(new Vector2(Input.GetAxis("Horizontal" + playerNumber), Input.GetAxis("Vertical" + playerNumber)));
        }
        if (Input.GetButtonDown("Jump" + playerNumber))
        {
            GetComponent<FootballPlayer>().Jump();
        }
        else if (Input.GetButtonUp("Jump" + playerNumber))
        {
            GetComponent<FootballPlayer>().InteruptJump();
        }
    }
}
