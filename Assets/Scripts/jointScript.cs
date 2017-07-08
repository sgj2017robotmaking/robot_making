using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childJointScript : MonoBehaviour {

    Rigidbody2D jointrb2D;

    void Start()
    {
        jointrb2D = GetComponent<Rigidbody2D>();
    }

    //Playerにhitしたら、親子化する
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            transform.SetParent(col.transform);
            Debug.Log("hit");
        }
    }
}
