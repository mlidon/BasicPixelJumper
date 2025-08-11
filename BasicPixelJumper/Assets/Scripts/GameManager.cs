using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  
    public TextMeshProUGUI scoreText;
    private int score = 0;

    
    // Método para sumar puntos
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
}
