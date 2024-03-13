using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private AiControler aiControler;
    public void  Set1Player()
    {
        aiControler.enabled = true;
        menu.SetActive(false);
    }
}
