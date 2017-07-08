using UnityEngine;
using System.Collections;

public class PlayerBehaviour: MonoBehaviour
{
    // 速度
    [SerializeField]
    private Vector2 SPEED = new Vector2(0.05f, 0.05f);

    //変数定義
    [SerializeField]
    private float flap = 1000f;
    [SerializeField]
    private float scroll = 5f;
    private float direction = 0f;
    private Rigidbody2D rb2d;
    private bool jump;
    private LayerMask Ground;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation; // 回転させないように、zだけ固定        //コンポーネント読み込み
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        // 移動処理
        Move();
    }

    // 移動関数
    void Move()
    {
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey("left"))
        {
            // 代入したPositionに対して加算減算を行う
            Position.x -= SPEED.x;
        }
        else if (Input.GetKey("right"))
        { // 右キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            Position.x += SPEED.x;
        }
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;

        //ジャンプ判定
        if (Input.GetKeyDown("space") && !jump)
        {
            rb2d.AddForce(Vector2.up * flap );
            jump = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }
    }
}