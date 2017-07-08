using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveScript : MonoBehaviour {

    private bool Switch;

    void Start()
    {
        Switch = true;
    }
    void Update () {
        
        GameObject player = GameObject.FindWithTag("Player");

        float length = Mathf.Abs(this.gameObject.transform.position.x * 0.8f - player.transform.position.x);
        float speed = 0.1f;
        float step = Time.deltaTime * speed;
        step = speed / length* -1.0f;
        if (Switch == true)
        {
            if (Input.GetKey("q"))
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
                Debug.Log("q");
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("!");

            this.gameObject.GetComponent<leaveScript>().enabled = false;
        }

    }
}
