using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageG_Floor : MonoBehaviour
{
    //����̈ʒu�ɓ��B����ƍ쓮����M�~�b�N�p�X�N���v�g(�쓮�ꏊ�̃I�u�W�F�N�g�ɃA�^�b�`)

[SerializeField] private StageGM gimicControl; //�M�~�b�N�Ǘ��p�X�N���v�g
[SerializeField] private GameObject floor;  
    private BoxCollider2D colliderF; //���̃R���C�_�[

    void Start()
    {
        colliderF = floor.GetComponent<BoxCollider2D>(); 
    }

    private void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.tag == "Player") //����L�����̃I�u�W�F�N�g�^�O
    {
            //�v���C���[������̈ʒu��ʉ߂����ۂɍ쓮

    }
   }
}
