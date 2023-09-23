using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEngine : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 10 * Time.deltaTime, 0);
        if(transform.position.y >= 5.7f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //EnemyManager.enemyCount--;
        }
    }
}
