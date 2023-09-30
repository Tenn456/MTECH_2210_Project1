using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badCoin : MonoBehaviour
{
    public float speed = 0;
    private AudioSource audioSource;
    public AudioClip deathSound;

    // Start is called before the first frame update
    void Start()
    {
        //Creates a random value between 5 and 10 and sets it to speed
        speed = Random.Range(5, 10);

        //Grabs audio source from the player object
        audioSource = GameObject.Find("Player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the coin move down at a speed depending on the random value generated
        transform.Translate(0, 1f * -speed * Time.deltaTime, 0);

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
            //sets the gameOver bool in gameManager1 to true
            GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver = true;

            //plays the death sound once
            audioSource.PlayOneShot(deathSound, 0.3f);
        }


    }
}
