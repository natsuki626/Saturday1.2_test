using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI timeText;

    private bool isGameOver = false;

    private float time = 30f;
    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        gameOverPanel.SetActive(false);
        UpdateUI();
    }

    private void Update()
    {
        if (isGameOver)
            return;

        time -= Time.deltaTime;

        if (time <= 0f)
        {
            time = 0f;
            GameClear();
        }

        UpdateUI();
    }

    public void GameOver()
    {
        if (isGameOver)
            return;

        isGameOver = true;

        gameOverPanel.SetActive(true);

        Debug.Log("GAME OVER");

        Time.timeScale = 0f;
    }

    private void GameClear()
    {
        isGameOver = true;

        Debug.Log("CLEAR");

        Time.timeScale = 0f;
    }

    private void UpdateUI()
    {
        timeText.text = "TIME : " + time.ToString("F1");
    }
}