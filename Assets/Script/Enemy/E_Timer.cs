using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Timer : MonoBehaviour
{
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

    private E_Move move;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<E_Move>();
    }

    // Update is called once per frame
    void Update()
    {
        //カウントダウン
        countdownSeconds -= Time.deltaTime;

        

        if (countdownSeconds <= 0)
        {
            if (ChgFlg == 0)
            {   
                move.SetAi(true);   
                
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
            else if (ChgFlg == 1)
            {
                //表世界の秒数
                countdownSeconds = fTime;                
                ChgFlg = 0;
                move.SetAi(false);
            }
        }
    } 
}
