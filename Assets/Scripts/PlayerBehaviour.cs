using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour: MonoBehaviour
{

    //変数定義
    public float flap = 1000f;
    public float scroll = 5f;
    float direction = 0f;
    bool jump = false;

    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {

        //キーボード操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }
        else
        {
            direction = 0f;
        }

    }

}