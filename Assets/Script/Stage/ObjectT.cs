using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectT : HPGM
{
    //�񕜂ł���I�u�W�F�N�g�̒�`
    public GameObject HPoint;
    //

    //�v���C���[���I�u�W�F�N�g�ɐG��Ă���ꍇ�񕜉\��Ԃɂ���
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ObjectTouch = true;
        }
    }
    //�v���C���[���I�u�W�F�N�g���痣�ꂽ�ꍇ�񕜕s�\��Ԃɖ߂�
    private void OnCollisionExit2D(Collision2D collision2D)
    {
        ObjectTouch = false;
    }
}
