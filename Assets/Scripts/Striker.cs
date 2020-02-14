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
            Counter.GetComponent<Counter>().strikes ++;
            Counter.GetComponent<Counter>().SetStrikeText();
        }
    }
}
