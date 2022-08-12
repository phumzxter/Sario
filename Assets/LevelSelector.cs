using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Level-" + level.ToString());
    }

    public void OpenScene1()
    {
        SceneManager.LoadScene("Level Selection");
    }

    public void OpenScene2()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
