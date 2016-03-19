using UnityEngine;
using System.Collections.Generic;

public class Card3 : MonoBehaviour
{

    public GameObject[] dayBars = new GameObject[17];
    LinkedList<Vector2> dayValues = new LinkedList<Vector2>();

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void StoreDayMoney()
    {
        dayValues.AddFirst(new Vector2(GameManagerScript.dayMoney, GameManagerScript.nextFloor));
        if(dayValues.Count == 18)
        {
            dayValues.RemoveLast();
        }
        Vector2 v;
        LinkedListNode<Vector2> n = dayValues.First;

        for (int i = 0; i < dayValues.Count; i++)
        {
            if (i == 0)
                n = dayValues.First;
            else
                n = n.Next;

            v = n.Value;

            if(v.x < 0)
            {
                v.x = 0;
            }
            else if(v.x > v.y)
            {
                v.x = v.y;
            }

            dayBars[i].GetComponent<RectTransform>().sizeDelta = new Vector2(25, (v.x * 200) / v.y);
        }
    }
}
