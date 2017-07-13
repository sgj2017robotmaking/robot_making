using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleCtrl : MonoBehaviour {

    [SerializeField]
    private UnityEngine.UI.Text PressSpaceKey;
    private float alpha;

	void Start () {
        alpha = 0;
	}
	
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("robot_making");
        }

        alpha = Mathf.PingPong(Time.time * 2, 1);
        PressSpaceKey.color = new Color(255.0f, 255.0f, 1, alpha);
	}
}
