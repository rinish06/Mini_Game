using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject Counter;

    void Update ()
    {
        transform.Rotate (new Vector3 (50, 50, 50) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "cannonball"))
        {
            this.gameObject.SetActive(false);
            Counter.GetComponent<Counter>().count ++;
            Counter.GetComponent<Counter>().SetCountText();
        }
    }
}
