using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiControler : FootballPlayer
{
    private void Update()
    {
        Vector2 distanceToBall = Ball.Instance.transform.position - transform.position;
        if (distanceToBall.x>-0.6f)
        {
            Run(1);
        }
        else
        {
            Run(-1);
        }

        if (distanceToBall.y > 0)
        {
            Jump();
        }
        else
        {
            InterruptJump();
        }
    }
}
