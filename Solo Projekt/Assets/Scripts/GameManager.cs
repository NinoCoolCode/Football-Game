using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject menu;
    [SerializeField] private AiControler aiControler;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    public void Set1Player()
    {
        aiControler.enabled = true;
        menu.SetActive(false);
        Time.timeScale = 1;

    }

    public void Set2Player()
    {
        playerController.enabled = true;

        menu.SetActive(false);
        Time.timeScale = 1;
    }


}
