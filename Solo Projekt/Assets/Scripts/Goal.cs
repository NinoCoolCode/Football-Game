using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
 [SerializeField]  private int goals;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ball ballScript))
        {
            Ball.Reset();
            goals++;

            foreach (FootballPlayer player in FindObjectsOfType<FootballPlayer>())
            {
                player.Reset();
            }
           
        }
    }
}
