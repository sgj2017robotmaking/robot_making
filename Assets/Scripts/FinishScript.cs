using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour {

    [SerializeField]
    private UnityEngine.UI.Text Finish;
    private float alpha;

	void Start () {
        alpha = 0;
	}
	
	void Update () {
        alpha = Mathf.PingPong(Time.time * 2,1);
        Finish.color = new Color(255.0f, 255.0f, 1, alpha);
	}
}
