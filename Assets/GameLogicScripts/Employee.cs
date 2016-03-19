using UnityEngine;
using System.Collections;

public class Employee : MonoBehaviour
{
    public string emp_name;
    public float isGoodPercentage = 50;
    
    public GameManagerScript game_manager_handle;

    public EnumGood[] good_acts;
    public EnumBad[] bad_acts;

    int currentAction = -1;

    public void Populate (string name, EnumGood[] good, EnumBad[] bad)
    {
        emp_name = name;
        good_acts = good;
        bad_acts = bad;
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
            yield return new WaitForSeconds(1);
            if (isGood)
                game_manager_handle.AddMoney(10);
            else
                game_manager_handle.RemoveMoney(10); ;
        }
                StartCoroutine(Action());
    }

}
