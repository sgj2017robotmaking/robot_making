using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//buhinを引き寄せるスクリプト
public class dropInScript : MonoBehaviour {

    [SerializeField]
    private int x = 5;
    [SerializeField]
<<<<<<< HEAD
    private float bairitu = 1f;
    [SerializeField]
    float speed = 0.1f;

=======
    private float bairitsu = 0.8f;
    [SerializeField]
    private float speed = 1.0f;
    private Vector3 buhin;
    private Vector3 playerPos;
    private float step;

    /*
>>>>>>> master
    void Start () {
		
	}
	*/

	void Update () {
        GameObject player = GameObject.FindWithTag("Player");

<<<<<<< HEAD
        float length = Mathf.Abs(Mathf.Abs(this.gameObject.transform.position.x * bairitu - player.transform.position.x) - Mathf.Abs(this.gameObject.transform.position.y * bairitu - player.transform.position.y));

        float step = Time.deltaTime * speed;
=======
        buhin = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        float length = Vector3.Distance(buhin, playerPos);

        speed = 0.1f;
        step = Time.deltaTime * speed;
>>>>>>> master
        step = speed / length ;
        if (length <= x)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
        }
	}

}
