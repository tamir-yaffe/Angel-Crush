using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonEngine : MonoBehaviour
{
    //gameobjects
    public GameObject demon;
    //variabels

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -10 * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
