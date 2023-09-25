using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));

        float xInput = Input.GetAxis("Horizontal");

        //If the game is not over, the player can move
        if(GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * xInput, 0, 0);
        }
        
    }
}
