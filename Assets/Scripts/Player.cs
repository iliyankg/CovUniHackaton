using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Transform centerAnchorTransform;
    public EmployeeFactory employeeFactory;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 fwd = centerAnchorTransform.TransformDirection(Vector3.forward);
            RaycastHit hit;
            Physics.Raycast(centerAnchorTransform.position, fwd, out hit, 30);
            Debug.DrawLine(centerAnchorTransform.position, hit.point);
            
            if (hit.transform.tag == "Office")
            {
                Office office = hit.transform.GetComponent<Office>();
                if (office.IsEmpty())
                {
                    if (GameManagerScript.playerMoney > 200)
                    {
                        employeeFactory.CreateEmployee(hit.transform.GetComponent<Office>());
                    }
                }
                else
                {
                    office.FireEmployee();
                }
            }
        }
	}
}
