using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin1 : MonoBehaviour
{
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Creates a random value between 5 and 10
        speed  = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the coin move down at a speed depending on the random value generated
        transform.Translate(0, 1f * - speed * Time.deltaTime, 0);

        //If the object goes too low, it is destroyed
        if (transform.position.y <= -9)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if object collides with the player
        if (collision.gameObject.tag == "Player")
        {
            //it is destroyed
            Destroy(gameObject);
        }


    }
}
