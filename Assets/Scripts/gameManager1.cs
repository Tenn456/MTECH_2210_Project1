using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class gameManager1 : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject badCoinPrefab;
    public GameObject themeCoinPrefab;
    public GameObject gameOverText;

    public AudioSource audioSource;
    public AudioClip death;

    private float widthValue = 8;
    private float heightValue = 6;
    public bool gameOver = false;
    public bool musicOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);

        //Calls SpawnCoin()
        SpawnCoin();

        SpawnBadCoin();

        SpawnThemeCoin();

        //Repeats SpawnCoin()
        InvokeRepeating("SpawnCoin", 4, 2);

        InvokeRepeating("SpawnBadCoin", 5, 3);

        InvokeRepeating("SpawnThemeCoin", 10, 8);


    }

    public void Update()
    {   
        //if gameOver is true
        if(gameOver)
        {
            //Stops all coins from spawning
            CancelInvoke();

            //displays game over text
            gameOverText.SetActive(true);

            //plays the game over sound once
            if(!musicOnce)
            {
                audioSource.PlayOneShot(death);
                musicOnce = true;
            }
        }
    }

    // Update is called once per frame
    public void SpawnCoin()
    {
        //Create a random value between 8 and -8
        float randomxValue = Random.Range(-widthValue, widthValue);

        //Creates a new Vector 3 using the random number generated before as the x value
        Vector3 pos = new Vector3(randomxValue, heightValue, 0);

        //Spawns the coin with the position of the Vector3
        GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);
    }

    public void SpawnBadCoin()
    {
        //Create a random value between 8 and -8
        float randomxValue = Random.Range(-widthValue, widthValue);

        //Creates a new Vector 3 using the random number generated before as the x value
        Vector3 pos = new Vector3(randomxValue, heightValue, 0);

        //Spawns the coin with the position of the Vector3
        GameObject coin = Instantiate(badCoinPrefab, pos, Quaternion.identity);
    }

    public void SpawnThemeCoin()
    {
        //Create a random value between 8 and -8
        float randomxValue = Random.Range(-widthValue, widthValue);

        //Creates a new Vector 3 using the random number generated before as the x value
        Vector3 pos = new Vector3(randomxValue, heightValue, 0);

        //Spawns the coin with the position of the Vector3
        GameObject coin = Instantiate(themeCoinPrefab, pos, Quaternion.identity);
    }
}
