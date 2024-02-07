using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 distanceToBall = Ball.Instance.transform.position - transform.position;
        if (distanceToBall.x>0)
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
          //  GetComponent<FootballPlayer>().Run(-1);
        }

    }
}
