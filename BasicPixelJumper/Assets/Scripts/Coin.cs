using UnityEngine;

public class Coin : MonoBehaviour
{

    private GameManager gameManager;

    void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gameManager.AddScore(1);
            Destroy(gameObject);
        }
    }
}
