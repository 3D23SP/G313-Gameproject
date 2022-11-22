using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeWarp : MonoBehaviour
{
    //分へ切り替え↓
    //public int countdownMinutes = 3;

    //切り替えまでの秒数の初期値
    public float countdownSeconds = 5;

    //表世界の秒数
    public int fTime = 5;

    //裏世界の秒数
    public int rTime0 = 10;
    public int rTime1 = 9;
    public int rTime2 = 11;

    //裏表のフラグ
    public int ChgFlg = 0;    
    
    //裏の世界の秒数の変化フラグ
    public int TimeRndFlg = 0;  

    //移動先の座標  
    private Vector3 target;

    //キャラクターの表世座標取得
    public Vector2 warpPoint;

    //裏ランダムスポーン
    public Transform[] rsPos;

    private FadeInOut fadeInOut;

    public bool fa;

    

    private void Start()
    {
        //countdownSeconds = countdownMinutes * 60;
        fa = false;
        fadeInOut = GetComponentInChildren<FadeInOut>();
    }

    void Update()
    {
        //カウントダウン
        countdownSeconds -= Time.deltaTime;
        Transform Transform = this.transform;
        Vector2 Pos = Transform.position;

        if (!fa)
        {
            if (countdownSeconds <= 2.0f)
            {
                fa = true;
            }
        }
        else if (fa)
        {
            fadeInOut.Fade();
            fa = false;
        }
        

        // 0秒になったときの処理
        if (countdownSeconds <= 0)
        {
            if (ChgFlg == 0)
            {
                //表世界の座標保存
                warpPoint.x = Pos.x;
                warpPoint.y = Pos.y;

                //裏世界の秒数
                if (TimeRndFlg == 0)
                {
                    
                    countdownSeconds = rTime0;
                    TimeRndFlg = 1;
                }
                else if(TimeRndFlg == 1)
                {
                    
                    countdownSeconds = rTime1;
                    TimeRndFlg = 2;
                }
                else if(TimeRndFlg == 2)
                {
                    
                    countdownSeconds = rTime2;
                    TimeRndFlg = 0;
                }

                //裏世界スポーンランダム設定
                int rnd = Random.Range(0, 5);
                gameObject.transform.position = rsPos[rnd].position;
                ChgFlg = 1;
            }            
            else if (ChgFlg == 1)
            {
                //表世界の秒数
                countdownSeconds = fTime;
                //target = gameObject.transform.position;
                target.x = warpPoint.x;
                target.y = warpPoint.y;
                gameObject.transform.position = target;
                ChgFlg = 0;
            }
        }
    }

   
}
