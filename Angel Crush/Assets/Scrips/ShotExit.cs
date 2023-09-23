using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotExit : MonoBehaviour
{
    // Game Objects
    public GameObject shotPreFab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
    }

    void Shot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shotPreFab, new Vector2(transform.position.x, transform.position.y)
                , shotPreFab.transform.rotation) ;
            //audioS.PlayOneShot(shotSound);
        }
    }
}
