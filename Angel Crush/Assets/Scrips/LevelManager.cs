using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    /* if instanciate not work properly remove this script from level manager
    and add it back*/ 
    public static int enemyAmount;
    // Start is called before the first frame update
    void Start()
    {
        //enemyAmount = Random.Range(10, 16);
        enemyAmount = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Level1();
    }
    void Level1()
    {
        if (enemyAmount == ShotEngine.hit)
        {
            print("good");
        }
    }
    void Level2()
    {

    }

}
