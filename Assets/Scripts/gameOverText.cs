using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverText : MonoBehaviour
{
    public float down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver == true)
        {
            if(transform.position.y > 0.17f)
            {
                transform.Translate(0, down, 0);
            }

        }
    }
}
