using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 startPosition;
    public void Reset()
    {
        transform.position = startPosition;
        GetComponent<Rigidbody2D>().velocity=new Vector3(0,0,0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
