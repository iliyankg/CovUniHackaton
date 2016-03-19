using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Card2 : MonoBehaviour
{
    public Text displayText;
    int currentEmployees;
    int potentialEmployees;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentEmployees = GameManagerScript.numberEmployees;
        potentialEmployees = GameManagerScript.numberOffices;
        displayText.text = "Employees: " + currentEmployees.ToString() + " of " + potentialEmployees.ToString();
    }
}
