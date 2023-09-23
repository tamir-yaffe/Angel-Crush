using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEngine : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 10 * Time.deltaTime, 0);
    }
}
