using UnityEngine;
using System.Collections;

public class Card0 : MonoBehaviour
{
    float topHeight;

    void Start()
    {
        topHeight = transform.parent.GetComponent<RectTransform>().sizeDelta.y;
    }

	// Update is called once per frame
	void Update ()
    {
        float amount = GameManagerScript.dayMoney;
        float minLimit = 0;
        float maxLimit = GameManagerScript.nextFloor;

        if (amount <= minLimit)
        {
            amount = minLimit;
        }
        else if (amount >= maxLimit)
        {
            amount = maxLimit;
        }

        if (amount >= minLimit && amount <= maxLimit)
        {
            GetComponent<RectTransform>().sizeDelta = new Vector2(40, (amount * topHeight) / maxLimit);
        }
    }
}
