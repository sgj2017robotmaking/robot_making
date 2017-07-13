using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//buhinをPlayerの子にして、くっつけるスクリプト
public class jointScript : MonoBehaviour {

    [SerializeField]
    private int count = 0;
    bool finish = false;

    //Playerにhitしたら、親子化する
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.SetParent(col.transform);
            //this.gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
//            Counter.partsCount += 1;
//          Counter.partslist.Add(this.gameObject.name);
//            if (Counter.partsCount > 9)
//            {
//                SceneManager.LoadSceneAsync("robot_making_test2");   //次のシーン
//                Debug.Log("!!");
//               for(int i=0;i<Counter.partslist.Count;i++)
//                {
//                    Debug.Log(Counter.partslist[i]);
//                }
//            }
        }
    }
}