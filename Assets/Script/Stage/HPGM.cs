using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPGM : MonoBehaviour
{
    //Sliderコンポーネントを管理する
    public Slider HPBar;
    //HPを定義
    public int HP = 1000;
    //毎フレームダメージに時間間隔を設定する
    double time = 0.0f;
    //ObjectTスクリプトにおけるオブジェクト衝突判定
    public bool ObjectTouch = false;
    //回復オブジェクト使用時に回復するHP量
    public int Healing = 100;

    void Start()
    {
        //HPバーを取得
        HPBar = GameObject.Find("HPBar").GetComponent<Slider>();
        //HPバーの最大値を1000にする
        HPBar.maxValue = 1000;
        //HPの初期値を最大値に設定する
        HPBar.value = 1000;
    }
    void Update()
    {
        //1秒ごとに内部の処理を行う
        time += Time.deltaTime;
        if (time >= 0.5f)
        {
            //毎フレーム1ダメージくらう
            HPBar.value -= 1;
            time = 0.0f;
        }
    }
}
