using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public Text countText;
    public Text strikeText;
    public Text winText;
    public Text loseText;
    public int count;
    public int strikes;
    public GameObject strikePlane;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        strikes = 0;
        SetCountText ();
        SetStrikeText ();
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
            strikePlane.SetActive(false);
        }
    }

    public void SetStrikeText ()
    {
        strikeText.text = "Strikes: " + strikes.ToString ();
        if (strikes >= 3)
        {
            loseText.text = "3 Strikes! Game Over!";
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
