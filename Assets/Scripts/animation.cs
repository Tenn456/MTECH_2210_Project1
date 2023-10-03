using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class animation : MonoBehaviour
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").GetComponent<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the speed condition in the animator to xInput. Will always be positive thanks to Mathf.Abs
        animator.SetFloat("Speed", Mathf.Abs(GameObject.Find("Player").GetComponent<movement>().xInput));

        //If the gameover bool is true, the moving animation stops
        if (GameObject.Find("Game Manager").GetComponent<gameManager1>().gameOver == true)
        {
            animator.SetFloat("Speed", 0);
            animator.SetBool("Death", true);

        }
    }
}
