using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jointScript : MonoBehaviour
{

    Rigidbody2D jointrb2D;

    void Start()
    {
        jointrb2D = GetComponent<Rigidbody2D>();
    }

    //buhinにhitしたら、親子化する
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "buhin")
        {
            transform.SetParent(col.transform);
            Debug.Log("hit");
        }
    }
}
