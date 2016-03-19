using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Card1 : MonoBehaviour
{
    public Text displayText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        displayText.text = "Budget: " + GameManagerScript.playerMoney + "DD";	    
	}
}
