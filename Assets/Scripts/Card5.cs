using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Card5 : MonoBehaviour
{

    public Text displayTextTime;
    public Text displayTextDay;
	
	// Update is called once per frame
	void Update ()
    {
        displayTextDay.text = "Days: " + GameManagerScript.day;
        displayTextTime.text = "Day end: " + GameManagerScript.timeLeft + "s";
	}
}
