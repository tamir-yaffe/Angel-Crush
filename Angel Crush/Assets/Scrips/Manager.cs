using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //Game Objects & Transforms
    public GameObject coin;
    public GameObject enemy;

    //Variables
    public static bool dropCoin;
    public static bool allEnemiesOut;
    // Start is called before the first frame update
    void Start()
    {
        dropCoin = false;
        allEnemiesOut = false;
        /*if (LevelManager.enemyAmount == ShotEngine.hit)
        {
            InvokeRepeating(nameof(CreateEnemies), Time.time, Random.Range(0.5f, 1.6f));
        }
        else
        {
            CancelInvoke(nameof(CreateEnemies));
        }*/
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShotEngine.dead == true)
        {
            CreateCoin();
            ShotEngine.dead = false;
        }


        /*if (allEnemiesOut == false)
        {
            allEnemiesOut = true;
            StartCoroutine(CreateDemons());
        }*/

    }
    IEnumerator CreateDemons()
    {
        for (int i = 0; i < LevelManager.enemyAmount; i++)
        {
            Instantiate(enemy, new Vector2(Random.Range(-2.3f, 2.31f), 2.8f), enemy.transform.rotation);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.6f));
        }
    }

    void CreateEnemies()
    {
        Instantiate(enemy, new Vector2(Random.Range(-2.3f, 2.31f), 2.8f), enemy.transform.rotation);
        
    }

    void CreateCoin()
    {
        Instantiate(coin, ShotEngine.deamonPos, coin.transform.rotation);
    }
}
