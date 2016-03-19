using UnityEngine;
using System.Collections;

public class AndroidTiltScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Input.gyro.rotationRateUnbiased.x, Input.gyro.rotationRateUnbiased.y, Input.gyro.rotationRateUnbiased.z);
        //transform.Rotate(0f, 1f, 0f);
	
	}
}
