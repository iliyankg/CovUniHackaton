using UnityEngine;
using System.Collections.Generic;

public enum EnumGood
{
    invalid = -1,
    spreadsheet,
    skope,
    coding,
    num_of_good
}

public enum EnumBad
{
    invalid = -1, 
    netflox,
    chatting,
    facepok,
    gaming,
    broozzers,
    num_of_good
}



public class EmployeeFactory : MonoBehaviour
{
    private string[] male_names =
        {
            "Bob Ross",
            "Harvey Spectre",
            "Louis Litt",
            "Trevor Evans",
            "Ian Evnas",
            "Kyle Durant",
            "Harold Gunderson",
            "Jimmy Kirkwood",
            "Travis Tanner",
            "Cameron Dennis",
            "Daniel Hardman",
            "Robert Zane",
            "Iliyan Georgiev",
            "Andrew Finley",
            "Ogre Razvan",
            "Gustavo Sanches",
            "Danny Hall",
            "Edward Darby",
            "Nigel Nesbitt",
            "Stephen Huntley",
            "Jonathan Sidwell",
            "Eric Woodall",
            "Sean Cahill",
            "Logan Sanders",
            "Jeff Malone",
            "Charles Forstman",
            "Jack Soloff"
        };

    private string[] female_names =
    {
        "Rachel Zane",
        "Jessica Pearson",
        "Donna Paulsen",
        "Jenny Griffith",
        "Iveta Stripey Cat", 
        "Dana Scott",
        "Sheila Sazs",
        "Monica Eaton", 
        "Katarina Bennett",
        "Ava Hessington",
        "Gretchen Bodinski"
    };

    public List<GameObject> ALL_EMPLOYEES;

    public GameObject EmployeeToInstantiate;

    public int threeGoodPercent = 90;
    public int twoGoodPercent = 40;

    public float upOffset = 2;
    public float rotationOffset = 90;

    private GameManagerScript gmScript;

    public float NumberGoodActs()
    {
        float count = 0;
        foreach(GameObject g in ALL_EMPLOYEES)
        {
            if (g.GetComponent<Employee>().isGood)
                count++;
        }
        return count;
    }

    public void CreateEmployee(Office office)
    {
        gmScript.RemoveMoney(200);
        GameManagerScript.numberEmployees++;
        GameObject temp = Instantiate(EmployeeToInstantiate, office.transform.position, office.transform.rotation) as GameObject;
        temp.GetComponent<Employee>().game_manager_handle = gmScript;

        EnumGood[] goodActs = GenerateGoodActs();
        EnumBad[] badActs = { };
        if (goodActs.Length != 3)
            badActs = GenerateBadActs(goodActs.Length);

        
        //TODO: Calculate spawn location
        temp.transform.SetParent(office.thisGameObject.transform, true);
        temp.transform.localPosition = office.employeePosition;
        temp.transform.localEulerAngles = office.employeeRotation;
        office.employee = temp.GetComponent<Employee>();
        temp.GetComponent<Employee>().Populate(GenerateName(), goodActs, badActs);

        ALL_EMPLOYEES.Add(temp);
    }


    void Start()
    {
        gmScript = GetComponent<GameManagerScript>();
    }

    void Update()
    {

    }

    private bool IsFemale()
    {
        float random = Random.Range(0f, 100f);
        return random > 50;
    }

    private string GenerateName()
    {
        bool isFemale = IsFemale();

        if (isFemale)
            return female_names[(int)Random.Range(0f, female_names.Length - 1)];
        else
            return male_names[(int)Random.Range(0f, male_names.Length - 1)];
    }

    public EnumGood[] GenerateGoodActs()
    {
        //Generate overal good number of actions
        float percentage = Random.Range(0f, 100f);
        int numberOfGoodActs = 1;
        if (percentage > threeGoodPercent)
            numberOfGoodActs = 3;
        else if (percentage > twoGoodPercent)
            numberOfGoodActs = 2;

        //Get random actions
        EnumGood[] toReturn = new EnumGood[numberOfGoodActs];

        int numOfGood = (int)EnumGood.num_of_good;

        for(int i = 0; i < numberOfGoodActs; ++i)
        {
            toReturn[i] = (EnumGood)Random.Range(0f, numOfGood);
        }

        if (numberOfGoodActs == 1)
            return toReturn;
        else if(numberOfGoodActs == 2)
        {
            while(toReturn[0] == toReturn[1])
            {
                toReturn[1] = (EnumGood)Random.Range(0f, numOfGood); 
            }
        }
        else if(numberOfGoodActs == 3)
        {
            while(toReturn[0] == toReturn[1] || toReturn[0] == toReturn[2])
                toReturn[0] = (EnumGood)Random.Range(0f, numOfGood);

            while(toReturn[1] == toReturn[2] || toReturn[1] == toReturn[0])
                toReturn[1] = (EnumGood)Random.Range(0f, numOfGood);
        }
        
        return toReturn;
    }
    public EnumGood[] GenerateGoodActs(int numOfGoodForce)
    {
        //Generate overal good number of actions
        int numberOfGoodActs = numOfGoodForce;

        //Get random actions
        EnumGood[] toReturn = new EnumGood[numberOfGoodActs];

        int numOfGood = (int)EnumGood.num_of_good;

        for (int i = 0; i < numberOfGoodActs; ++i)
        {
            toReturn[i] = (EnumGood)Random.Range(0f, numOfGood);
        }

        if (numberOfGoodActs == 1)
            return toReturn;
        else if (numberOfGoodActs == 2)
        {
            while (toReturn[0] == toReturn[1])
            {
                toReturn[1] = (EnumGood)Random.Range(0f, numOfGood);
            }
        }
        else if (numberOfGoodActs == 3)
        {
            while (toReturn[0] == toReturn[1] || toReturn[0] == toReturn[2])
                toReturn[0] = (EnumGood)Random.Range(0f, numOfGood);

            while (toReturn[1] == toReturn[2] || toReturn[1] == toReturn[0])
                toReturn[1] = (EnumGood)Random.Range(0f, numOfGood);
        }

        return toReturn;
    }
    public EnumBad[] GenerateBadActs(int numGoodActs)
    {
        if (numGoodActs != 3)
        {
            int numBadActs = 3 - numGoodActs;
            EnumBad[] toReturn = new EnumBad[numBadActs];

            int numOfGood = (int)EnumBad.num_of_good;

            for (int i = 0; i < numBadActs; ++i)
            {
                toReturn[i] = (EnumBad)Random.Range(0f, numOfGood);
            }

            if (numBadActs == 1)
                return toReturn;
            else if (numBadActs == 2)
            {
                while (toReturn[0] == toReturn[1])
                {
                    toReturn[1] = (EnumBad)Random.Range(0f, numOfGood);
                }
            }
            return toReturn;
        }
        else
            return new EnumBad[] { };
    }
}
