using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private PlayerController leftPlayer;
    [SerializeField] private PlayerController rightPlayer;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private int timer = 120;

    private void Awake()
    {
        Time.timeScale = 0;
        UpdateTimer();
        InvokeRepeating(nameof(CountDown),1,1);
        startMenu.SetActive(true);

    }

    public void Set1Player()
    {
        leftPlayer.GetComponent<PlayerController>().enabled = true;
        rightPlayer.GetComponent<AiControler>().enabled = true;

        startMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Set2Player()
    {
        leftPlayer.GetComponent<PlayerController>().enabled = true;
        rightPlayer.GetComponent<PlayerController>().enabled = true;

        startMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void UpdateTimer()
    {
        int minutes = timer / 60;
        int seconds = timer - minutes * 60;

        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void CountDown()
    {
        timer--;
        UpdateTimer();
    }
}
