using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    public void GameOver()
    {
        Debug.Log("Game Over! Final Score: " + score);
        // Add additional game over logic here (e.g., stop gameplay, show menu)
        Time.timeScale = 0f; // Freeze the game
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
        // Add additional score effects here if needed
    }
}