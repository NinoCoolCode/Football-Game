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


    public static void Reset()
    {
        for (int i = activeBalls.Count-1; i >= 0; i--)
        {
            Ball currentBall = activeBalls[i];
            if (Instance == currentBall)
            {
                currentBall.transform.position = currentBall.startPosition;
                currentBall.ChangeBall(BallType.normal);

                Rigidbody2D currentRb = currentBall.GetComponent<Rigidbody2D>();
                currentRb.velocity = new Vector3(0, 0, 0);
                currentRb.angularVelocity = 0;
            }
            else
            {
                activeBalls.Remove(currentBall);
                Destroy(currentBall.gameObject);
            }


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
        ChangeBall(BallType.normal);
        if (Instance == null)
        {
            Instance = this;
           
        }
    }

    private void Start()
    {
        startPosition = transform.position;
        football = GetComponent<SpriteRenderer>().sprite ;
    }
}
