using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHeal : HPBarS
{

    //プレイヤーがオブジェクトに触れている場合回復可能状態にする
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HMFrame.SetActive(true);
        }
    }
    //プレイヤーがオブジェクトから離れた場合回復不可能状態に戻す
    private void OnCollisionExit2D(Collision2D collision2D)
    {
        HMFrame.SetActive(false);
    }

    //HPの減少速度を正常にする為に必要
    void Update()
    {

    }
}
