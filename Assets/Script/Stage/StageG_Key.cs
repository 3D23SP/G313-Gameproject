using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageG_Key : MonoBehaviour
{
    [SerializeField]
    private StageGM gimicControl; //�M�~�b�N�Ǘ��p�X�N���v�g
    private void OnTriggerEnter(Collider other)
    {
                //�L�[�A�C�e���擾�p�X�N���v�g
        if(other.gameObject.tag == "Player") //����L�����̃I�u�W�F�N�g�^�O
        {
            gimicControl.item = true;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false; //�A�C�e���̊O���\���𖳌���
            this.gameObject.GetComponent<SphereCollider>().enabled = false; //�A�C�e���̓����蔻��𖳌���
        }
    }
}
