using UnityEngine;

public enum PowerUpType
{
    RoboBall,
    MultiBall,
    Freeze,
    FireBall
}

public class PowerUp : MonoBehaviour
{
    [SerializeField] private PowerUpType powerUpType;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerController player))
        {
          
            Destroy(gameObject);
            switch (powerUpType)
            {
                case PowerUpType.RoboBall:
                case PowerUpType.Freeze:
                    player.ActivatePowerUp(powerUpType);
                    break;
                case PowerUpType.MultiBall:
                    Ball.Instance.Duplicate();
                    break;
                case PowerUpType.FireBall:
                    Ball.Instance.FireBall();
                    break;
                default:
                    break;

            }
        }
    }
}
