using UnityEngine;
using System.Collections;

public class Office : MonoBehaviour
{
    public GameObject thisGameObject;
    public Employee employee;

    public Vector3 employeePosition;
    public Vector3 employeeRotation;

	// Use this for initialization
	void Start ()
    {
        thisGameObject = gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public bool IsEmpty()
    {
        return (employee == null);
    }

    public void FireEmployee()
    {
        Destroy(employee.gameObject);
        employee = null;
    }
}
