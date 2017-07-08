using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaincameraContoroller : MonoBehaviour {

    [SerializeField]
    private GameObject player;
	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 11, -10);

        if (transform.position.x < 4)
        {
            transform.position = new Vector3(4, 11, -10);
        }

        if (transform.position.x >= 300)
        {
            transform.position = new Vector3(300, 11, -10);
        }
    }
}
