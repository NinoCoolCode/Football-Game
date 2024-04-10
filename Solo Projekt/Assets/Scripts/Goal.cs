using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
   private int goals;
    [SerializeField] private TMP_Text goalText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ball ballScript))
        {
            Ball.Reset();
            goals++;
            goalText.text = goals.ToString();

            foreach (FootballPlayer player in FindObjectsOfType<FootballPlayer>())
            {
                player.Reset();
            }
        }           
    }
}
