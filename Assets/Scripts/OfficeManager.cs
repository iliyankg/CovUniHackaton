using UnityEngine;
using System.Collections.Generic;

public class OfficeManager : MonoBehaviour
{
    public List<Office> offices = new List<Office>();
    public int numberFloors;
    public int startingFloors;
    public float velocity = 5f;

    public GameObject floor;
    public List<GameObject> officesPrefab = new List<GameObject>();

    private Vector3[] officePositions = { new Vector3(0, 0, 0), new Vector3(-8.3f, 0, -1.8f), new Vector3(8.3f, 0, -1.8f), new Vector3(-15.1f, 0, -6.9f), new Vector3(15.1f, 0, -6.9f) };
    private Vector3[] officeRotations = { new Vector3(270, 180, 0), new Vector3(270, 155.5f, 0), new Vector3(270, 204.5f, 0), new Vector3(270, 131, 0), new Vector3(270, 229, 0) };

    // Use this for initialization
    void Start ()
    {
        numberFloors = 0;
        for(int i = 0; i < startingFloors; i++)
        {
            CreateFloor(i);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveOffice();
	}

    public void CreateFloor(int number)
    {
        numberFloors++;
        Transform temp = transform.FindChild("roof");
        temp.localPosition = new Vector3(temp.localPosition.x, temp.localPosition.y + 5f, temp.localPosition.z);

        GameManagerScript.numberOffices += 5;
        GameObject obj = Instantiate(floor, new Vector3(0, number * 5, 0), Quaternion.identity) as GameObject;
        obj.transform.SetParent(transform, false);
        obj.name = "Floor" + (number + 1);
        for (int i = 0; i < 5; i++)
        {
            int roomType = Random.Range(0, officesPrefab.Count);

            GameObject obj2 = Instantiate(officesPrefab[roomType]);

            obj2.GetComponent<Office>().officeType = roomType;

            switch (roomType)
            {
                case 0:
                    obj2.GetComponent<Office>().sittingPosition= new Vector3(-0.281f, -1.752f, 1.639f);
                    obj2.GetComponent<Office>().sittingRotation = new Vector3(29.76165f, 270f, 270f);
                    break;
                case 1:
                    obj2.GetComponent<Office>().sittingPosition = new Vector3(0.684f, -1.297f, 1.639f);
                    obj2.GetComponent<Office>().sittingRotation = new Vector3(51.08162f, 269.9999f, 269.9999f);
                    break;
                case 2:
                    obj2.GetComponent<Office>().sittingPosition = new Vector3(-0.893f, -0.667f, 1.64f);
                    obj2.GetComponent<Office>().sittingRotation = new Vector3(70.57999f, 90.00022f, 90.00016f);
                    break;

            }



            obj2.name = "Room" + (i + 1);
            obj2.transform.SetParent(obj.transform, false);
            obj2.transform.localPosition = officePositions[i];
            obj2.transform.localEulerAngles = officeRotations[i];
            offices.Add(obj2.GetComponent<Office>());
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
