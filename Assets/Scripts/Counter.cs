using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public Text loseText;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        winText.text = ""; 
        loseText.text = "";  
    }

    /*void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "baseball"))
        {
            //other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }*/

    public void SetCountText ()
    {
        countText.text = "Targets Hit: " + count.ToString ();
        if (count >= 5)
        {
            winText.text = "You Win!";
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
