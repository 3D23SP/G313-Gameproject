using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHeal : HPBarS
{

    //�v���C���[���I�u�W�F�N�g�ɐG��Ă���ꍇ�񕜉\��Ԃɂ���
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HMFrame.SetActive(true);
        }
    }
    //�v���C���[���I�u�W�F�N�g���痣�ꂽ�ꍇ�񕜕s�\��Ԃɖ߂�
    private void OnCollisionExit2D(Collision2D collision2D)
    {
        HMFrame.SetActive(false);
    }

    //HP�̌������x�𐳏�ɂ���ׂɕK�v
    void Update()
    {

    }
}
