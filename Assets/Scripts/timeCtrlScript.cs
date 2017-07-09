using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//60秒後にシーンを移動させるスクリプト
public class timeCtrlScript : MonoBehaviour {

    void Start()
    {
        Debug.Log("start");
        //(メソッド,秒数)を指定
        Invoke("timeManagement", 60);   //60秒後にtimeManagementを呼び出す。
    }
    //「Invoke」で呼び出すメソッド
    void timeManagement()
    {
        SceneManager.LoadScene("robot_making_test2");   //次のシーンの名前をお願いします。
    }    
}
