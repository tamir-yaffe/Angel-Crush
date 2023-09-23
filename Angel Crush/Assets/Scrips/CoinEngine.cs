using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEngine : MonoBehaviour
{
    public GameObject coin;
    Vector2 coinForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinForce = new Vector2(Random.Range(0, 1.5f), Random.Range(0, 1.5f));
        transform.Translate(0, -1.5f * Time.deltaTime, 0);
        if(transform.position.y < -5.7f)
        {
            Destroy(gameObject);
        } 
    }
}
