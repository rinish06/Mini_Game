using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    void Update ()
    {
        transform.Rotate (new Vector3 (50, 50, 50) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "baseball"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
