using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int enemyAmount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyAmount = Random.Range(10, 16);
    }
    void Level1()
    {
        if (enemyAmount == 0)
        {
            print("good");
        }
    }
    void Level2()
    {

    }

}
