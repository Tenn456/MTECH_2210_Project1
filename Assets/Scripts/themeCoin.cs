using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class themeCoin : MonoBehaviour
{
    public float speed = 0;
    private AudioSource audioSource;
    public AudioClip breakSound;

    // Start is called before the first frame update
    void Start()
    {
        //Creates a random value between 5 and 10
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
            //temporarily prints change theme in console
            print("Change Theme");

            //plays the monitor break sound once
            audioSource.PlayOneShot(breakSound, 0.3f);
        }


    }
}
