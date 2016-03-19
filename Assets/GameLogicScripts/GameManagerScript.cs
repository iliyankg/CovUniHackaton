using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    public EmployeeFactory EMPLOYEE_FACTORY;

    public static float playerMoney = 1000f;

    public static int numberEmployees;
    public static int numberOffices;



    public void AddMoney(float moneyToAdd)
    {
        playerMoney += moneyToAdd;
    }
    public void RemoveMoney(float moneyToRemove)
    {
        playerMoney -= moneyToRemove;
    }


	// Use this for initialization
	void Start ()
    {
        EMPLOYEE_FACTORY = transform.GetComponent<EmployeeFactory>();
        numberEmployees = 0;
        numberOffices = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
