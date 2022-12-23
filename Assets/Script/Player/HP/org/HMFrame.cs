using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMFrame : HPGM
{
    void Start()
    {
        //ゲーム開始直後では、該当するオブジェクトをFALSE状態とする
        HMFrame.SetActive(false);
    }
}
