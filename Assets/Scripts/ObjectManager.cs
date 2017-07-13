﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {

    private GameObject player_prefab;
    private Script_SpriteStudio_Root player_ScriptRoot;

    // Use this for initialization
    void Start() {
        LoadSpriteStudioObject("animation/Charactor01/Prefab/Charactor01");
           ChangeAnimationSpriteStudioObject("wait");
        player_prefab.transform.localScale = new Vector3(0.005f, 0.005f, 1f);
        player_prefab.transform.position = new Vector3(10, 20, 0);

        // 子供のオブジェクトを探す
        GameObject go_arm_l = player_prefab.transform.Find("part_1/body/arm_left02").gameObject;
        go_arm_l.AddComponent<BoxCollider2D>();
        go_arm_l.tag = "attachpoint";

        GameObject go_arm_r = player_prefab.transform.Find("part_1/body/arm_right02").gameObject;
        go_arm_r.AddComponent<BoxCollider2D>();
        go_arm_r.tag = "attachpoint";
        //		LoadSpriteStudioObject("animation/character_template1/Prefab/character_template_3head");
        //		LoadSpriteStudioObject("animation/character_sample1/Prefab/character_template_3head",new Vector3(300,-300,0));
    }

    // Update is called once per frame
    void Update() {

        if (null == player_ScriptRoot)
        {
            // SpriteStudioのオブジェクトを制御するためのルートオブジェクトの取得
            //      ScriptRoot = Library_SpriteStudio.Utility.Parts.RootGetChild(gameObject);
            player_ScriptRoot = Library_SpriteStudio.Utility.Parts.RootGetChild(player_prefab.gameObject);
        }
        else
        {
            // アニメーションを切り替える
            if (Input.GetKeyDown("1"))
            {
                ChangeAnimationSpriteStudioObject("wait");
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ChangeAnimationSpriteStudioObject("dash");
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                ChangeAnimationSpriteStudioObject("wait");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ChangeAnimationSpriteStudioObject("dash");
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                ChangeAnimationSpriteStudioObject("wait");
            }
            else if (Input.GetKeyDown("a"))
            {
                ChangeAnimationSpriteStudioObject("attack");
            }
            else if (Input.GetKeyUp("a"))
            {
                ChangeAnimationSpriteStudioObject("anime_1");
            }
        }

        float x = Input.GetAxisRaw("Horizontal");
        // デフォルトが右向きの画像の場合
        // スケール値取り出し
        Vector3 scale = transform.localScale;
        if (x >= 0)
        {
            // 右方向に移動中
            scale.x = -1; // そのまま（右向き）
        }
        else
        {
            // 左方向に移動中
            scale.x = 1; // 反転する（左向き）
        }
        // 代入し直す
        transform.localScale = scale;
        
    }

    // SpriteStudioのオブジェクトを読み込むサンプル
    void LoadSpriteStudioObject(string filePath, Vector3? _pos = null)
    {
        Vector3 pos;
        if (_pos == null) {
            pos = new Vector3(0, -300, 0); // 表示する位置を初期化
        } else {
            pos = (Vector3)_pos;
        }

        player_prefab = Instantiate(Resources.Load(filePath), pos, Quaternion.identity) as GameObject;
        player_prefab.transform.parent = this.transform;
    }
    // SpriteStudioのオブジェクトのアニメーションを切り替えるサンプル
    void ChangeAnimationSpriteStudioObject(string animationName)
  {
        if(player_ScriptRoot == null)
        {
            Debug.Log("animationkirikae");
            return;
        }
    player_ScriptRoot.AnimationPlay(player_ScriptRoot.IndexGetAnimation(animationName));
  }
}