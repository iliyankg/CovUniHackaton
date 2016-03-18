using UnityEngine;
using System.Collections;

public class Employee {

    public string emp_name;
    public float dailyMoneyContribution;

    EnumGood[] good_acts;
    EnumBad[] bad_acts;

    public Employee (string name, EnumGood[] good, EnumBad[] bad, float expectedContribution)
    {
        emp_name = name;
        good_acts = good;
        bad_acts = bad;
        dailyMoneyContribution = expectedContribution - (0.1f * (bad.Length - 1) * expectedContribution);
    }

}
