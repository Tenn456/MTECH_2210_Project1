using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5;
    public Animator animator;
    public bool facingRight = true;
    public float xInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Everything under here only happens if gameover bool from the gameManager1 script is false
        if (GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver == false)
        {
            //Movement Script
            Debug.Log(Input.GetAxisRaw("Horizontal"));

            xInput = Input.GetAxis("Horizontal");

            transform.Translate(speed * Time.deltaTime * xInput, 0, 0);

            

            //Calls Flip Function if Sonic is moving and is not facing to the right
            if (Input.GetAxis("Horizontal") > 0 && !facingRight)
            {
                Flip();
            }

            //Calls Flip Function if Sonic is moving and is facing to the right
            if (Input.GetAxis("Horizontal") < 0 && facingRight)
            {
                Flip();
            }
        }

        

        

        

    }

    void Flip()
    {
        //Uses scale to flip the sprite
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        //Keeps track of which direction sonic is
        facingRight = !facingRight;
    }
}
