using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //Game Objects & Transforms
    public GameObject coin;
    public GameObject enemy;
    public Transform enemyLoaction;
    Vector2 coinExit;
    Vector2 coinForce;

    //Variables
    public static bool dropCoin;
    bool allEnemiesOut;
    // Start is called before the first frame update
    void Start()
    {
        dropCoin = false;
        allEnemiesOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        //coinExit = new Vector2(enemyLoaction.position.x, enemyLoaction.position.y);
        //coinForce = new Vector2(Random.Range(0, 1.5f), Random.Range(0, 1.5f));
        if (ShotEngine.dead == true)
        {
            CreateCoin();
            ShotEngine.dead = false;
        }
        if (allEnemiesOut == false)
        {
            StartCoroutine(CreateDemons());
            allEnemiesOut = true;
        }
    }
    IEnumerator CreateDemons()
    {
        for (int i = 0; i < LevelManager.enemyAmount; i++)
        {
            Instantiate(enemy, new Vector2(Random.Range(-2.3f, 2.31f), 2.8f), enemy.transform.rotation);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.6f));
        }
        allEnemiesOut = true;
    }
    /*void DropCoins()
    {
        Instantiate(coin, coinExit, coin.transform.rotation);
        coin.AddComponent<Rigidbody2D>();
        coin.GetComponent<Rigidbody2D>().AddForce(coinForce);
    }*/

    void CreateCoin()
    {
        Instantiate(coin, new Vector2(transform.position.x, transform.position.y), coin.transform.rotation);
    }
}
