using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
//(2.1,3.7)(-2.1,3.7)
{
    // GameObjects & UI
    public GameObject player;
    public TMP_Text scoreText;
    public TMP_Text coinsText;
    
    // Variabels
    float dir;
    int speed;
    int score;
    int coins;
    void Start()
    {
        speed = 5;
        transform.position = new Vector2(0, -3.7f);
        score = 0;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        scoreText.SetText("SCORE: " + score);
        coinsText.SetText("COINS: " +  coins);
    }

    private void Movement()
    {
        dir = Input.GetAxis("Horizontal");
        if (dir > 0 && transform.position.x < 2.3f)
        {
            transform.Translate(dir * speed * Time.deltaTime, 0, 0);
        }
        else if (dir < 0 && transform.position.x > -2.3f)
        {
            transform.Translate(dir * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            dir = 0;
        }
    }
<<<<<<< HEAD
   

=======
>>>>>>> 967cbb4d2617b8012344fa405e097e8fc9cc4f05
}
