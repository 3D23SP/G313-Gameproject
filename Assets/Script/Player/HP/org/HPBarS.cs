using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPBarS :  HPGM
{
    //HPバーフラグ用のオブジェクト
    public GameObject HPBarFlg;

    void Start()
    {
        //HPバーを取得
        HPBar = GameObject.Find("HPBar").GetComponent<Slider>();
        //HPバーの最大値をHPにする
        HPBar.maxValue = HP;
        //HPバーの初期値をHPに
        HPBar.value = 100;
        
}
    void Update()
    {

        if(HPBarFlg.activeSelf)
        {
            //1秒ごとに内部の処理を行う
            time += Time.deltaTime;
            if (time >= 1.0f)
            {
                //1秒ごとに2ダメージくらう
                HPBar.value -= 2;
                HP -= 2;
                time = 0.0f;
            }
        }
        

        if (HP <= 0)
        {
            //シーンをゲームオーバーに変更する
            SceneManager.LoadScene("GameOver");
        }

        if (HMFrame.activeSelf)
        {
            //スペースキーを押した際
            if (Input.GetKeyDown("e"))
            {
                //プレイヤーを回復し、オブジェクトを消す
                HPBar.value += Healing;
                HP += Healing;
                HealObject.SetActive(false);
                HMFrame.SetActive(false);
            }
        }

        //HPは上限を超えて回復しないようにする
        if (HP >= 100)
        {
            HP = 100;
        }

    }
}
