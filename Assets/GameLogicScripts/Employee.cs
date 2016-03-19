using UnityEngine;
using System.Collections;

public class Employee : MonoBehaviour
{
    private int dayTimeInSecconds = 120;
    private int currentDayTime = 0;
    private int elapsedDays = 0;

    public string emp_name;
    public float isGoodPercentage = 50f;
    public float canDegradePercentage = 50f;
    public float specialistPercentage = 90f;

    public GameManagerScript game_manager_handle;

    public EnumGood[] good_acts;
    public EnumBad[] bad_acts;

    private int currentAction = -1;
    private Office parentOffice;

    [HideInInspector] public bool canDegradeFlag;
    /*[HideInInspector]*/ public bool isSpecialist;


    public void Populate (string name, EnumGood[] good, EnumBad[] bad)
    {
        emp_name = name;
        good_acts = good;
        bad_acts = bad;

        if (Random.Range(0f, 100f) >= canDegradePercentage)
            canDegradeFlag = true;
        else
            canDegradeFlag = false;

        if(Random.Range(0f, 100f) >= specialistPercentage)
        {
            isSpecialist = true;
            canDegradeFlag = true;
            DegradeActions(3);
        }
        else
        {
            isSpecialist = false;
        }
        parentOffice = transform.parent.GetComponent<Office>();
    }

    private void DegradeActions()
    {
        if(good_acts.Length != 1)
        {
            good_acts = game_manager_handle.EMPLOYEE_FACTORY.GenerateGoodActs(good_acts.Length - 1);
            bad_acts = game_manager_handle.EMPLOYEE_FACTORY.GenerateBadActs(good_acts.Length);
        }
        else
        {
            Debug.Log("Cant Degrade More");
        }
    }

    private void DegradeActions(int specialForce)
    {
        good_acts = game_manager_handle.EMPLOYEE_FACTORY.GenerateGoodActs(specialForce);
        bad_acts = game_manager_handle.EMPLOYEE_FACTORY.GenerateBadActs(good_acts.Length);
    }

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Action());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Action()
    {
        bool isGood;

        if (Random.Range(0f, 100f) > 100 - isGoodPercentage)
            isGood = true;
        else
            isGood = false;

        if (good_acts.Length == 3)
            isGood = true;

        /**************ANIM SWITCH******************/
        if (isGood)
        {
            currentAction = (int)good_acts[Random.Range(0, good_acts.Length)];
            switch((EnumGood)currentAction)
            {
                case EnumGood.spreadsheet:
                    parentOffice.ChangeScreens("Textures/Good/Materials/good_spreadsheet");
                    break;
                case EnumGood.skope:
                    parentOffice.ChangeScreens("Textures/Good/Materials/good_skope");
                    break;
                case EnumGood.coding:
                    parentOffice.ChangeScreens("Textures/Good/Materials/good_coding");
                    break;
            }
        }
        else if(!isGood)
        {
            currentAction = (int)bad_acts[Random.Range(0, bad_acts.Length)];
            switch ((EnumBad)currentAction)
            {
                case EnumBad.netflox:
                    parentOffice.ChangeScreens("Textures/Bad/Materials/bad_netflox");
                    break;
                case EnumBad.chatting:
                    parentOffice.ChangeScreens("Textures/Bad/Materials/bad_chatting");
                    break;
                case EnumBad.facepok:
                    parentOffice.ChangeScreens("Textures/Bad/Materials/bad_facepok");
                    break;
                case EnumBad.gaming:
                    parentOffice.ChangeScreens("Textures/Bad/Materials/bad_gaming");
                    break;
                case EnumBad.broozzers:
                    parentOffice.ChangeScreens("Textures/Bad/Materials/bad_broozzers");
                    break;
            }
        }

        //Seconds to run for
        int secondsToRunFor = Random.Range(5, 10);
        for (int i = 0; i <= secondsToRunFor; ++i)
        {
            currentDayTime++;
            if(currentDayTime > dayTimeInSecconds)
            {
                currentDayTime = 0;
                elapsedDays++;
            }
            
            yield return new WaitForSeconds(1);
            if (isGood)
                game_manager_handle.AddMoney(10);
            else
                game_manager_handle.RemoveMoney(10); ;
        }

        if (elapsedDays >= 3)
        {
            elapsedDays = 0;

            if (!isSpecialist)
                DegradeActions();
            else
                DegradeActions(1);
        }
        StartCoroutine(Action());
    }

}
