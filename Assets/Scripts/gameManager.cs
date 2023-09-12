using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject coinPrefab;
    private float heightValue = 4;
    private float widthValue = 8;
    public Color[] coinColor;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoin();

        InvokeRepeating("SpawnCoin", 4, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoin()
    {
        float randomxValue = Random.Range(-widthValue, widthValue);
        float randomyValue = Random.Range(-heightValue, heightValue);

        Vector3 pos = new Vector3(randomxValue, randomyValue, 0);
        GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);

        coin coinScript = coin.GetComponent<coin>();

        int rndValue = Random.Range(0, 3);
        coinScript.ChangeCoinValue(rndValue);
        coinScript.ChangeCoinColor(coinColor[rndValue]);
    }
}
