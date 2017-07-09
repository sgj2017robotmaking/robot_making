using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//buhinを管理するスクリプト
public class buhinScript : MonoBehaviour
{
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (Vector2.Distance(player.transform.position, transform.position) <= 5.0f)
        {
            //this.gameObject.GetComponent<dropInScript>().enabled = true;
            this.gameObject.GetComponent<jointScript>().enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("!");

            this.gameObject.GetComponent<dropInScript>().enabled = false;
        }

    }
}
