using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropInScript : MonoBehaviour {

    [SerializeField]
    private int x = 5;
    void Start () {
		
	}
	
	void Update () {
        GameObject player = GameObject.FindWithTag("Player");
        
        float length =Mathf.Abs(this.gameObject.transform.position.x*0.5f - player.transform.position.x);
        float speed = 0.1f;
        float step = Time.deltaTime * speed;
        step = speed / length ;
        if (length <= x)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
        }
	}

}
