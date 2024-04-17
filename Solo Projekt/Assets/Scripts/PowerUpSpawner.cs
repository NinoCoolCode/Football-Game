using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] private GameObject powerUp;
    
   public void Spawn()
    {
        Instantiate(powerUp,transform.position,transform.rotation);
       
    }
}


