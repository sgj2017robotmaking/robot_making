using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropInScript : MonoBehaviour {

    [SerializeField]
    private int x = 5;
    [SerializeField]
    private float bairitu = 1f;
    [SerializeField]
    float speed = 0.1f;

    void Start () {
		
	}
	
	void Update () {
        GameObject player = GameObject.FindWithTag("Player");

        float length = Mathf.Abs(Mathf.Abs(this.gameObject.transform.position.x * bairitu - player.transform.position.x) - Mathf.Abs(this.gameObject.transform.position.y * bairitu - player.transform.position.y));

        float step = Time.deltaTime * speed;
        step = speed / length ;
        if (length <= x)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
        }
	}

}
