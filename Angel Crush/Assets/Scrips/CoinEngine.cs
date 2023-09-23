using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEngine : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1.5f * Time.deltaTime, 0);
        if(transform.position.y < -5.7f)
        {
            Destroy(gameObject);
        }

        if (ShotEngine.dead== true)
        {
            CreateCoin();
            ShotEngine.dead = false;
        }
    }

    void CreateCoin()
    {
        Instantiate(coin, new Vector2(transform.position.x, transform.position.y), coin.transform.rotation);
    }
}
