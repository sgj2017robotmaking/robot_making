using UnityEngine;
using System.Collections;

public class kariMove : MonoBehaviour
{

    Rigidbody2D rigid2D;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    Rigidbody2D jointrb2D;
    bool hit;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.jointrb2D = GetComponent<Rigidbody2D>();
        hit = false;
    }

    void Update()
    {

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        // プレイヤの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

    }
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("hit");
        if (col.gameObject.tag == "buhin")
        {
            transform.parent=transform;
        }
    }
    */

}
