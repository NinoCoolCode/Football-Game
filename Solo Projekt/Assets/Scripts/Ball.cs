using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BallType
{
    normal,
    robo
}

public class Ball : MonoBehaviour

{
    [SerializeField] private Sprite roboBall;
   [SerializeField] private Sprite football;

    public static Ball Instance;
    private Vector3 startPosition;
    private static List<Ball> activeBalls = new List<Ball>();


    public void Reset()
    {
        for (int i = activeBalls.Count-1; i >= 0; i--)
        {
            if (Instance != this)
            {
                activeBalls.Remove(this);
                Destroy(gameObject);
            }
            transform.position = startPosition;
            ChangeBall(BallType.normal);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody2D>().angularVelocity = 0;

        }
        
    }
    public void Duplicate()
    {
        Instantiate(gameObject);
    }
    public void SetVelocity(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction;
        ChangeBall(BallType.robo);
        transform.rotation = Quaternion.identity;
    }
    public void ChangeBall(BallType ballType)
    {
        switch (ballType)
        {
            case BallType.normal:
                GetComponent<SpriteRenderer>().sprite = football;
                break;

            case BallType.robo:
                GetComponent<SpriteRenderer>().sprite = roboBall;
                break;
        }
    }

    private void Awake()
    {
        activeBalls.Add(this);   
        if (Instance == null)
        {
            Instance = this;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
       football = GetComponent<SpriteRenderer>().sprite ;

    }

    // Update is called once per frame
    
}
