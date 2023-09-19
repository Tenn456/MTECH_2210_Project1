using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player1 : MonoBehaviour
{
    public float movementSpeed;
    Rigidbody2D rb;
    public float xMove;
    public float yMove;
    public TextMeshPro playerscoreText;
    public int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");

        playerscoreText.text = playerScore.ToString();

        //transform.Translate(Time.deltaTime * movementSpeed * xMove, 0, 0);



    }

    public void Score(int scoreChange)
    {
        playerScore += scoreChange;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Time.deltaTime * movementSpeed * xMove, Time.deltaTime * movementSpeed * yMove);
    }
}
