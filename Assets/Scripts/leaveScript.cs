using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//buhinを離れさせるスクリプト
public class leaveScript : MonoBehaviour {

    [SerializeField]
    private float speed = 50.0f;
    [SerializeField]
    private float nameraka = 0.8f;
    [SerializeField]
    private float x = 5.0f;

    private Vector3 buhin;
    private Vector3 playerPos;
    private float step;

    GameObject player;
    kariMove km;    //プレイヤーの動きのコンポーネントを宣言。

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        km = player.GetComponent<kariMove>();   //プレイヤーの動きのスクリプトをお願いします。
    }
    void Update () {
        
        buhin = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        float length = Vector3.Distance(buhin,playerPos);
        step = Time.deltaTime * speed;
        step = speed / length*-1.0f;
          if (length <= x)
          {
            if (Input.GetKey("a"))
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
  //              km.canMove = false; //プレイヤーの動きのコンポーネントをfalseにする。
            }
        }
   //     if (Input.GetKeyUp("a"))
  //      {
   //         km.canMove = true;  //プレイヤーの動きのコンポーネントをtrueにする。
   //     }

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
