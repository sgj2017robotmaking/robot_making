using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//buhinをPlayerの子にして、くっつけるスクリプト
public class jointScript : MonoBehaviour {

    //Playerにhitしたら、親子化する
    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.tag == "Player")
        {
            transform.SetParent(col.transform);
        }
    }
}
