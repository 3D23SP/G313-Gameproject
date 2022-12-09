using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectT : HPGM
{
    //回復できるオブジェクトの定義
    public GameObject HPoint;
    //

    //プレイヤーがオブジェクトに触れている場合回復可能状態にする
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ObjectTouch = true;
        }
    }
    //プレイヤーがオブジェクトから離れた場合回復不可能状態に戻す
    private void OnCollisionExit2D(Collision2D collision2D)
    {
        ObjectTouch = false;
    }
}
