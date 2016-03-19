using UnityEngine;
using System.Collections.Generic;

public class OfficeManager : MonoBehaviour
{
    public List<Office> offices = new List<Office>();
    public int numberFloors;
    public float velocity = 5f;

    public GameObject floor;

	// Use this for initialization
	void Start ()
    {
        for(int i = 0; i < numberFloors; i++)
        {
            CreateFloor(i);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveOffice();
	}

    void CreateFloor(int number)
    {
        GameObject obj = Instantiate(floor, new Vector3(0, number * 5, 0), Quaternion.identity) as GameObject;
        obj.transform.SetParent(transform, false);
        obj.name = "Floor" + (number + 1);
        for(int i = 0; i < 5; i++)
        {
            offices.Add(obj.transform.GetChild(i).GetComponent<Office>());
        }
    }

    void MoveOffice ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, -velocity * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, velocity * Time.deltaTime, 0);
        }

        if (transform.position.y > 0)
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        else if (transform.position.y < -(numberFloors - 1) * 5)
            transform.position = new Vector3(transform.position.x, -(numberFloors - 1) * 5, transform.position.z);

    }
}
