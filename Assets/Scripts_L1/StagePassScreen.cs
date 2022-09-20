using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StagePassScreen : MonoBehaviour
{

    public static int numberOfCoins;
    public static int numberOfEnemy;
    public TextMeshProUGUI numberOfCoinsText;
    public TextMeshProUGUI numberOfEnemyText;

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
        
    }

    public void NextButton() {
        SceneManager.LoadScene("Level-2");
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
