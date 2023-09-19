using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager1 : MonoBehaviour
{
    public GameObject coinPrefab;
    private float widthValue = 8;
    private float heightValue = 6;

    // Start is called before the first frame update
    void Start()
    {
        //Calls SpawnCoin()
        SpawnCoin();

        //Repeats SpawnCoin()
        InvokeRepeating("SpawnCoin", 4, 2);
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
}
