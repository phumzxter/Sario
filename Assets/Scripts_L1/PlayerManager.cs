using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static int numberOfCoins;
    public static int numberOfEnemy;
    public TextMeshProUGUI numberOfCoinsText;
    public TextMeshProUGUI numberOfEnemyText;

    public GameObject GameOverScreen;

    public static bool IsGameOver;

    void Awake()
    {
        IsGameOver = false;
    }
    
    void Start()
    {
        numberOfCoins = PlayerPrefs.GetInt("numberOfCoins", 0);
        numberOfEnemy = PlayerPrefs.GetInt("numberOfEnemy", 0);
    }

    void Update()
    {
        numberOfCoinsText.text = "Coins:" + numberOfCoins;
        numberOfEnemyText.text = "Kills:" + numberOfEnemy;
        PlayerPrefs.SetInt("numberOfCoins", numberOfCoins);
        PlayerPrefs.SetInt("numberOfEnemy", numberOfEnemy);

        if (IsGameOver)
        {
            GameOverScreen.SetActive(true);
        }
    }

    public void RestartButton() {
        SceneManager.LoadScene("Level-1");
        PlayerPrefs.Save();
        PlayerPrefs.DeleteAll();
        numberOfCoins = PlayerPrefs.GetInt("numberOfCoins", 0);
        numberOfEnemy = PlayerPrefs.GetInt("numberOfEnemy", 0);

        
    }

    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
    }
}
