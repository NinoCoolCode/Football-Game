using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private TMP_Text goalText;
    [SerializeField] private GameObject goalImage;
    private int goals;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Ball ballScript))
        {
           
            goals++;
            goalText.text = goals.ToString();
            goalImage.SetActive(true);

            Invoke(nameof(Reset),1);
        }           
    }

    private void Reset()
    {
        Ball.Reset();
        foreach (FootballPlayer player in FindObjectsOfType<FootballPlayer>())
        {
            print("ONE PLAYER: " + player.gameObject.name);
            player.Reset();
        }
        goalImage.SetActive(false);
        GetComponentInChildren<PowerUpSpawner>().Spawn();
    }
}
