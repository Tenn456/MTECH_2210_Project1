using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badCoin : MonoBehaviour
{
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Creates a random value between 5 and 10
        speed = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the coin move down at a speed depending on the random value generated
        transform.Translate(0, 1f * -speed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver = true;
        }


    }
}
