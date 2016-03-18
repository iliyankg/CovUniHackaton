using UnityEngine;
using System.Collections;

public enum EnumGood
{
    invalid = -1,
    fileroom,
    presenting, 
    pcwork, 
    photocopy,
    meeting,
    cleaning,
    num_of_good
}

public enum EnumBad
{
    invalid = -1, 
    nutflix,
    chatting,
    socialmedia,
    gaming,
    num_of_good
}

public class EmployeeFactory
{
    EmployeeFactory() { }

    public Employee CreateEmployee()
    {

    }

}
