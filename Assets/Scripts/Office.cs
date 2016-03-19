using UnityEngine;
using System.Collections;

public class Office : MonoBehaviour
{
    public GameObject thisGameObject;
    public GameObject screen;
    public Employee employee;

    public Vector3 employeePosition;
    public Vector3 employeeRotation;

	// Use this for initialization
	void Start ()
    {
        thisGameObject = gameObject;
        screen = transform.GetChild(0).GetChild(0).gameObject;
	}

    public bool IsEmpty()
    {
        return (employee == null);
    }

    public void FireEmployee()
    {
        GameManagerScript.numberEmployees--;
        Destroy(employee.gameObject);
        employee = null;
        ChangeScreens("Materials/Black screen");
    }

    public void ChangeScreens(string name)
    {
        screen.GetComponent<Renderer>().material = Resources.Load(name) as Material;
    }
}
