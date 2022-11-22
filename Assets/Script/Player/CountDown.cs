using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //public int countdownMinutes = 3;

    //切り替えまでの秒数の初期値
    private float countdownSeconds = 5;

    //表世界の秒数
    public int fTime = 5;

    //裏世界の秒数
    public int rTime0 = 10;
    public int rTime1 = 9;
    public int rTime2 = 11;

    //カウントダウンのテキスト
    private Text timeText;

    //裏表のフラグ
    public int ChgFlg = 0;

    //裏の世界の秒数の変化フラグ
    public int TimeRndFlg = 0;


    private void Start()
    {
        timeText = GetComponent<Text>();
        //countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        //カウントダウン
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        //カウントダウンの秒数表示
        timeText.text = span.ToString(@"mm\:ss");

        // 0秒になったときの処理
        if (countdownSeconds <= 0)
        {            
            //裏世界の秒数
            if(ChgFlg == 0)
            {
                if (TimeRndFlg == 0)
                {
                    countdownSeconds = rTime0;
                    TimeRndFlg = 1;
                }
                else if (TimeRndFlg == 1)
                {
                    countdownSeconds = rTime1;
                    TimeRndFlg = 2;
                }
                else if (TimeRndFlg == 2)
                {
                    countdownSeconds = rTime2;
                    TimeRndFlg = 0;
                }
                ChgFlg = 1;
            }
            //表世界の秒数
            else if(ChgFlg == 1)
            {
                countdownSeconds = fTime;
                ChgFlg = 0;
            }
            
        }
    }
}
