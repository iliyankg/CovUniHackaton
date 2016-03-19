using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Transform centerAnchorTransform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.Space))
        {
            Vector3 fwd = centerAnchorTransform.TransformDirection(Vector3.forward);
            RaycastHit hit;
            Physics.Raycast(centerAnchorTransform.position, fwd, out hit, 30);
            Debug.DrawLine(centerAnchorTransform.position, hit.point);
        }
	}
}
