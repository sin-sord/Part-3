using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using static Unity.VisualScripting.Dependencies.Sqlite.SQLite3;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public Rigidbody2D rb;
    public float timer = 0;
    public int score = 0;
    ScoreTracker scoreTrack;
    TextMeshProUGUI coinCollected;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // if collision between the game object with the tag "Player" happens...
        {
            Destroy(gameObject); // desotry the object
            ScoreTracker.keepScore += 5; // add "5" to the score
            ScoreTracker.SetCurrentCoin(coinCollected);  // set the score text 
        }
    }

    protected virtual void Update()
    {
        timer += 1 * Time.deltaTime;  // have a timer that counts up by 1
        if (timer > 5)  // when the timer goes past 5...
        {
            Destroy(gameObject);  //  destory the object
            ScoreTracker.missedCoins += 1;  // add "1" to the "Missed coins" counter
        }

        if(ScoreTracker.missedCoins == 4)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;  //  says which scene to go to
            SceneManager.LoadScene(nextSceneIndex);  //  loads the game scene
        }

    }
}
