using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

{
    public static Ball Instance;
    private Vector3 startPosition;

    public void Reset()
    {
        transform.position = startPosition;
        GetComponent<Rigidbody2D>().velocity=new Vector3(0,0,0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
    }
    private void Awake()
    {
        Instance = this;
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
