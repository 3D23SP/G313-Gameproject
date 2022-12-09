using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageG_Floor : MonoBehaviour
{
    //特定の位置に到達すると作動するギミック用スクリプト(作動場所のオブジェクトにアタッチ)

[SerializeField] private StageGM gimicControl; //ギミック管理用スクリプト
[SerializeField] private GameObject floor;  
    private BoxCollider2D colliderF; //↑のコライダー

    void Start()
    {
        colliderF = floor.GetComponent<BoxCollider2D>(); 
    }

    private void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.tag == "Player") //操作キャラのオブジェクトタグ
    {
            //プレイヤーが特定の位置を通過した際に作動

    }
   }
}
