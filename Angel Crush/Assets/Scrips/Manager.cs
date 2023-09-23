using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //Game Objects & Transforms
    public GameObject coin;
    public Transform enemyLoaction;
    Vector2 coinExit;
    Vector2 coinForce;

    //Variables
    public static bool dropCoin;
    // Start is called before the first frame update
    void Start()
    {
        dropCoin = false;
    }

    // Update is called once per frame
    void Update()
    {
        coinExit = new Vector2(enemyLoaction.position.x, enemyLoaction.position.y);
        coinForce = new Vector2(Random.Range(0, 1.5f), Random.Range(0, 1.5f));
        if (dropCoin)
        {
            DropCoins();
            dropCoin = false;
        }
    }
    void DropCoins()
    {
        Instantiate(coin, coinExit, coin.transform.rotation);
        coin.AddComponent<Rigidbody2D>();
        coin.GetComponent<Rigidbody2D>().AddForce(coinForce);
    }
}
