using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souchi1_Rotate_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(0, 0.02f, 0));

    }
}
