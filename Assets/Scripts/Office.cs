using UnityEngine;
using System.Collections;

public class Office : MonoBehaviour
{
    public int officeType;
    public Vector3 sittingPosition;
    public Vector3 sittingRotation;
    public GameObject thisGameObject;
    public GameObject screen;
    public Employee employee;
    public string LorR;

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
        GameManagerScript.EMPLOYEE_FACTORY.ALL_EMPLOYEES.Remove(employee.gameObject);
        GameManagerScript.numberEmployees--;
        Destroy(employee.gameObject);
        employee = null;
        ChangeScreens("Materials/Black screen");
        transform.GetChild(0).GetComponent<AudioSource>().Stop();
    }

    public void ChangeScreens(string name)
    {
        screen.GetComponent<Renderer>().material = Resources.Load(name) as Material;
    }

    public void ChangeSound(string name)
    {
        transform.GetChild(0).GetComponent<AudioSource>().clip = Resources.Load(name) as AudioClip;
        transform.GetChild(0).GetComponent<AudioSource>().Play();
    }
}
