using UnityEngine;

public class PlayerController : FootballPlayer
{
    [SerializeField] private int playerNumber = 1;
    [SerializeField] private Ball ball;

    // Update is called once per frame
    void Update()
    {
        Run(Input.GetAxis("Horizontal" + playerNumber));
        
        if (hasRoboBall)
        {
            ball.SetVelocity(new Vector2(Input.GetAxis("Horizontal" + playerNumber), Input.GetAxis("Vertical" + playerNumber)));
        }
        if (Input.GetButtonDown("Jump" + playerNumber))
        {
            Jump();
        }
        else if (Input.GetButtonUp("Jump" + playerNumber))
        {
            InterruptJump();
        }
    }
}
