using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public GameObject StartScreen;
    public static bool gameStarted = false;

    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();

        if (!gameStarted)
        {
            Time.timeScale = 0;
            StartScreen.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            StartScreen.SetActive(false);
            ScoreText.gameObject.SetActive(true);
        }
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void StartGame()
    {
        gameStarted = true;
        Time.timeScale = 1;
        StartScreen.SetActive(false);
        ScoreText.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        gameStarted = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
