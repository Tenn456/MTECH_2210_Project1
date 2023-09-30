using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the game is over, the background music stops
        if(GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver == true)
        {
            audioSource.Stop();
        }
    }
}
