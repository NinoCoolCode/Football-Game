using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiControler : MonoBehaviour
{
    private void Update()
    {
        Vector2 distanceToBall = Ball.Instance.transform.position - transform.position;
        if (distanceToBall.x>-0.6f)
        {
            GetComponent<FootballPlayer>().Run(1);

        }
        else
        {
            GetComponent<FootballPlayer>().Run(-1);
        }

        if (distanceToBall.y > 0)
        {
            GetComponent<FootballPlayer>().Jump();
        }
        else
        {
            GetComponent<FootballPlayer>().InteruptJump();
        }
    }
}
