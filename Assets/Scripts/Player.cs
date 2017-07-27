using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("c")) {
//			Vector3 pos = transform.position;
			Vector3 pos = transform.position;
			pos =  new Vector3(0.1f, 0.1f, -0.1f);
			transform.position = pos;
		}
	}
}
