using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5;
    public Animator animator;
    public bool facingRight = true;
    
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

            float xInput = Input.GetAxis("Horizontal");

            transform.Translate(speed * Time.deltaTime * xInput, 0, 0);

            //For Animation
            animator.SetFloat("Speed", Mathf.Abs(xInput));

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

        

        //If the gameover bool is true, the moving animation stops
        if (GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver == true)
        {
            animator.SetFloat("Speed", 0);
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
