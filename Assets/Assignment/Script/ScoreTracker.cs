using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using Unity.VisualScripting;

public class ScoreTracker : MonoBehaviour
{
    public static float keepScore = 0;
    public static float totalCoin = 0;
    public static float missedCoins = 0;
    public TextMeshProUGUI scoreUpdate;
    public TextMeshProUGUI coinCollected;
    public TextMeshProUGUI coinMissed;

    public static void SetCurrentCoin()
    {
        print("Coin Collected");  //  prints that the coins are being collected

    }

    public void Update()
    {
        scoreUpdate.text = "Score: " + keepScore.ToString();  //  text that updates as the player collects a coin
        coinCollected.text = "Coins Spawned: " + totalCoin.ToString();  // text that updates to show how many coins have spawned
        coinMissed.text = "Coins missed: " + missedCoins.ToString();  //  text that updates to show how many coins the player misses
    }


}
