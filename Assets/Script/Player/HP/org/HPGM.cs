using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPGM : MonoBehaviour
{
    //Sliderコンポーネントを管理する
    public  Slider HPBar;
    //HPを定義
    public int HP = 100;
    //毎フレームダメージに時間間隔を設定する
    public float time = 0.0f;

    //ObjectTスクリプトにおけるオブジェクト衝突判定
    public bool ObjectT = false;
    //回復オブジェクト使用時に回復するHP量
    public int Healing = 10;
    //テキスト表示用オブジェクトの定義
    public GameObject HMFrame;
    //回復できるオブジェクトの定義
    public GameObject HealObject;


    void Start()
    {

    }
    void Update()
    {

    }
}
