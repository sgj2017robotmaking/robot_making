using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//buhinを引き寄せるスクリプト
public class dropInScript : MonoBehaviour {

    [SerializeField]
    private int x = 5;
    [SerializeField]
    private float bairitu = 1f;
    [SerializeField]
    float speed = 0.1f;
    private float bairitsu = 0.8f;
    private Vector3 buhin;
    private Vector3 playerPos;
    private float step;

    /*
>>>>>>> master
    void Start () {
		
	}
	*/

    public void setmove(bool flag)
    {
        move = flag;
        Debug.Log("setmove");
    }        
        private bool move = true;

    void MoveToTarget() {
        GameObject player = GameObject.FindWithTag("Player");

        buhin = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        float length = Vector3.Distance(buhin, playerPos);

        speed = 0.1f;
        step = Time.deltaTime * speed;
        step = speed / length ;
        if (length <= x)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
        }
	}

    private void Update()
    {
        if (move)
        {
            MoveToTarget();
        }
    }


}
