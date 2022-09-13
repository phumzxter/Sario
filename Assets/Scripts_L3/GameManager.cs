using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinScore;
    public TextMeshProUGUI coinScoreTxt;

    void Start()
    {
        coinScore = 0;
        coinScoreTxt.text = "Coin: " + coinScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoinScore() {
        coinScore += 1;
        coinScoreTxt.text = "Coin: " + coinScore;
    }
}
