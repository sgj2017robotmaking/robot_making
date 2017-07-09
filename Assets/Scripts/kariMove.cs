using UnityEngine;
using System.Collections;

//仮で作った動き
//コメントアウトしてあるところを追加してください。
public class kariMove : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    bool hit;
    public bool canMove = true; //ここ

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        hit = false;
    }

    void Update()
    {
        int key = 0;
        if (canMove == true)    //移動のところに書く
        {
            if (Input.GetKey(KeyCode.RightArrow)) key = 1;
            if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        }
        // プレイヤの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
    }
}
