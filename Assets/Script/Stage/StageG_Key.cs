using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageG_Key : MonoBehaviour
{
    [SerializeField]
    private StageGM gimicControl; //ギミック管理用スクリプト
    private void OnTriggerEnter(Collider other)
    {
                //キーアイテム取得用スクリプト
        if(other.gameObject.tag == "Player") //操作キャラのオブジェクトタグ
        {
            gimicControl.item = true;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false; //アイテムの外見表示を無効化
            this.gameObject.GetComponent<SphereCollider>().enabled = false; //アイテムの当たり判定を無効化
        }
    }
}
