using UnityEngine;

public enum PowerUpType
{
    RoboBall,
    MultiBall,
    Freeze
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
                default:
                    break;
            }
        }
    }
}
