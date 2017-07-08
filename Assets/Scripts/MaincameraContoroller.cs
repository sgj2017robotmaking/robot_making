using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaincameraContoroller : MonoBehaviour {

    private Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position + new Vector3(0, 1, -3);
    }
}
