using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    public EmployeeFactory EMPLOYEE_FACTORY;

    public float playerMoney = 1000f;



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
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
