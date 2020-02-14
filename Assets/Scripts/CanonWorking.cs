using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonWorking : MonoBehaviour
{
    public GameObject cannonball;
    

    public int speed = 50;

    public int count =0;

    private int delay = 0;

    public GameObject Counter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Counter.GetComponent<Counter>().strikes < 3)
        {
            delay = delay + 1;
            if (delay == 1)
            {

                GameObject clone = Instantiate(cannonball, transform.position, transform.rotation);

                clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, speed));

                count = count + 1;







            }
            if (delay == 250)
            {
                delay = 0;
            }
        }
    }

}
