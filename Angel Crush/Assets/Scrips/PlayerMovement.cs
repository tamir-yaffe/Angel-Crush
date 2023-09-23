using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
//(2.1,3.7)(-2.1,3.7)
{
    // GameObjects
    public GameObject player;
    
    // Variabels
    float dir;
    int speed;
    void Start()
    {
        speed = 5;
        transform.position = new Vector2(0, -3.7f);
    }

    // Update is called once per frame
    void Update()
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

}
