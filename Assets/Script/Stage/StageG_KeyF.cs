using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageG_KeyF : MonoBehaviour
{

    //キーアイテムの所持で開閉状況が変わるゲート用スクリプト
    
    [SerializeField]private StageGM gimicControl;   //ギミック管理用スクリプト
    [SerializeField]private GameObject gate;
    private BoxCollider colliderK;

    void Start()
    {
        colliderK = gate.GetComponent<BoxCollider>();
    }
        
        private void OnTriggerEnetr(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            if(gimicControl.item) 
            {
                colliderK.isTrigger = true; 
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(!gimicControl.item) 
            {
                colliderK.isTrigger = false; 
            }
        }
    }
}
