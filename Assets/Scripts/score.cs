using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.ComponentModel;

public class score : MonoBehaviour
{
    public int rings = 0;
    public TextMeshPro scoreText;
    public AudioSource audioSource;
    public AudioClip ringCollect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If sonic collides with a ring
        if (collision.gameObject.CompareTag("ring"))
        {
            //ring int increases by 1
            rings++;
            //Sets the score text to ring, which has been translated into a string
            scoreText.text = rings.ToString();
            //Plays the ring collect sound effect
            audioSource.PlayOneShot(ringCollect, 0.3f);
        }
    }
}
