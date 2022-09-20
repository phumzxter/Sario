using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public void RestartButton() {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Level-1");

    }

    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
    }
}
