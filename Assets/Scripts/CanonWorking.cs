using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonWorking : MonoBehaviour
{
    public GameObject cannonball;
    public float rateoffire = 1;
    public float speed = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clone = Instantiate(cannonball, transform.position, transform.rotation);
        clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3(0,0,speed));
        Physics.IgnoreCollision(clone.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
    }
}
