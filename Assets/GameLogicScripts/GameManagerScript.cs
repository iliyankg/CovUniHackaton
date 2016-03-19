using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    public static EmployeeFactory EMPLOYEE_FACTORY;
    public static OfficeManager officeManagerHandle;
    public Card3 bars;
    public float floorMultiplier;

    public static float playerMoney = 1000f;
    public static float dayMoney;

    public static float nextFloor;

    public static int numberEmployees;
    public static int numberOffices;
    public static int dayCicle;
    public static int timeLeft;
    public static int day;


    public void AddMoney(float moneyToAdd)
    {
        playerMoney += moneyToAdd;
        dayMoney += moneyToAdd;
    }
    public void RemoveMoney(float moneyToRemove)
    {
        playerMoney -= moneyToRemove;
        dayMoney -= moneyToRemove;
    }


	// Use this for initialization
	void Start ()
    {
        EMPLOYEE_FACTORY = transform.GetComponent<EmployeeFactory>();
        officeManagerHandle = FindObjectOfType<OfficeManager>();
        numberEmployees = 0;
        numberOffices = 0;
        day = 0;
        dayCicle = 120;
        timeLeft = dayCicle;
        dayMoney = 0;
        nextFloor = 1000;
        InvokeRepeating("Countdown", 1, 1);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void Countdown()
    {
        if(--timeLeft == 0)
        {
            day += 1;
            timeLeft = dayCicle;
            bars.StoreDayMoney();
            CheckDayMoney();
            dayMoney = 0;
        }
    }

    void CheckDayMoney()
    {
        if(dayMoney >= nextFloor)
        {
            nextFloor *= floorMultiplier;
            officeManagerHandle.CreateFloor(officeManagerHandle.numberFloors);
        }
    }
}
