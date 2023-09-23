using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonEngine : MonoBehaviour
{
    public GameObject demon;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -2 * Time.deltaTime, 0);
        if (transform.position.y <-5.7f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            
        }
    }
}
