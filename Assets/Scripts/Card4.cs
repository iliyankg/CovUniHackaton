using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Card4 : MonoBehaviour
{
    public Text displayText;
    float productivity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameManagerScript.EMPLOYEE_FACTORY.ALL_EMPLOYEES.Count != 0)
        {
            productivity = (GameManagerScript.EMPLOYEE_FACTORY.NumberGoodActs() * 100 / (float)GameManagerScript.EMPLOYEE_FACTORY.ALL_EMPLOYEES.Count);
        }
        else
        {
            productivity = 0;
        }
        if (productivity > 50)
            displayText.color = Color.green;
        else if (productivity == 50)
            displayText.color = Color.yellow;
        else
            displayText.color = Color.red;

        displayText.text = productivity.ToString("0.00") + "%";
    }
}
