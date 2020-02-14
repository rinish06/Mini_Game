using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : MonoBehaviour
{
    public GameObject Counter;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "cannonball"))
        {
            if (Counter.GetComponent<Counter>().strikes < 3)
            {
                Counter.GetComponent<Counter>().strikes++;
                Counter.GetComponent<Counter>().SetStrikeText();
            }
        }
    }
}
