using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    public float hp = 30;
    public bool on_damage = false;
    private SpriteRenderer renderer;

    // Use this for initialization
    void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (on_damage)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            renderer.color = new Color(1f, 1f, 1f, level);
        }
    }

    void OnDamageEffect(int damage)
    {
        if (!on_damage)
        {
            // gotDamage
            hp = hp - damage;

            if (hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                //changeFlg
                on_damage = true;
                StartCoroutine("WaitForDamage");
            }
        }
    }


    IEnumerator WaitForDamage()
    {
        yield return new WaitForSeconds(0.5f);

        on_damage = false;
        renderer.color = new Color(1f, 1f, 1f, 1f);
    }
}
