using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatCollision : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    
    private void onCollision(Collision collision)
    {
        if (collision.gameObject.CompareTag("cannonball"))
        {
            audio.Play();
        }
    }
}
