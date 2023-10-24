using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BossHP : MonoBehaviour
{
    public int enemyHP;// 敵の最大HP
    private int wkHP;  // 敵の現在のHP
    public Slider hpSlider;     //HPバー

    Animator animator;

    void Start()
    {
        hpSlider.value = (float)enemyHP;//HPバーの最初の値（最大HP）を設定
        wkHP = enemyHP; // 現在のHPを最大HPに設定
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrriger En");
        // あたった場合敵を削除
        if (other.gameObject.CompareTag("Shot"))
        {
            wkHP -= 1;//一度当たるごとに1をマイナス
            hpSlider.value = (float)wkHP / (float)enemyHP;//スライダは０〜1.0で表現するため最大HPで割って少数点数字に変換
            // HPが0以下になった場合、自らを消す
            if (wkHP == 0)
            {
                GetComponent<ParticleSystem>().Play();
                animator.SetBool("Die", true);
                //Debug.Log("Destroy");
                Destroy(gameObject, 0f);
            }

        }
    }
}
