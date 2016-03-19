using UnityEngine;
using System.Collections;

public class Employee : MonoBehaviour
{
    private int dayTimeInSecconds = 120;
    private int currentDayTime = 0;
    private int elapsedDays = 0;

    public string emp_name;
    public float isGoodPercentage = 50;
    public float canDegradePercentage = 50f;

    public GameManagerScript game_manager_handle;

    public EnumGood[] good_acts;
    public EnumBad[] bad_acts;

    private int currentAction = -1;

    [HideInInspector] public bool canDegradeFlag;


    public void Populate (string name, EnumGood[] good, EnumBad[] bad)
    {
        emp_name = name;
        good_acts = good;
        bad_acts = bad;

        if (Random.Range(0f, 100f) > canDegradePercentage)
            canDegradeFlag = true;
        else
            canDegradeFlag = false;
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

        /**************ANIM SWITCH******************/
        if (isGood)
        {
            currentAction = Random.Range(0, good_acts.Length - 1);
            switch((EnumGood)currentAction)
            {
                case EnumGood.fileroom:
                    break;
                case EnumGood.skype:
                    break;
                case EnumGood.pcwork:
                    break;
                case EnumGood.photocopy:
                    break;
            }
        }
        else if(!isGood)
        {
            currentAction = Random.Range(0, bad_acts.Length - 1);
            switch ((EnumBad)currentAction)
            {
                case EnumBad.nutflix:
                    break;
                case EnumBad.chatting:
                    break;
                case EnumBad.socialmedia:
                    break;
                case EnumBad.gaming:
                    break;
                case EnumBad.onphone:
                    break;
                case EnumBad.fapfap:
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

            if(elapsedDays >= 3)
            {
                elapsedDays = 0;

            }

            yield return new WaitForSeconds(1);
            if (isGood)
                game_manager_handle.AddMoney(10);
            else
                game_manager_handle.RemoveMoney(10); ;
        }
                StartCoroutine(Action());
    }

}
