using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPBarS :  HPGM
{
    //HP�o�[�t���O�p�̃I�u�W�F�N�g
    public GameObject HPBarFlg;

    void Start()
    {
        //HP�o�[���擾
        HPBar = GameObject.Find("HPBar").GetComponent<Slider>();
        //HP�o�[�̍ő�l��HP�ɂ���
        HPBar.maxValue = HP;
        //HP�o�[�̏����l��HP��
        HPBar.value = 100;
        
}
    void Update()
    {

        if(HPBarFlg.activeSelf)
        {
            //1�b���Ƃɓ����̏������s��
            time += Time.deltaTime;
            if (time >= 1.0f)
            {
                //1�b���Ƃ�2�_���[�W���炤
                HPBar.value -= 2;
                HP -= 2;
                time = 0.0f;
            }
        }
        

        if (HP <= 0)
        {
            //�V�[�����Q�[���I�[�o�[�ɕύX����
            SceneManager.LoadScene("GameOver");
        }

        if (HMFrame.activeSelf)
        {
            //�X�y�[�X�L�[����������
            if (Input.GetKeyDown("e"))
            {
                //�v���C���[���񕜂��A�I�u�W�F�N�g������
                HPBar.value += Healing;
                HP += Healing;
                HealObject.SetActive(false);
                HMFrame.SetActive(false);
            }
        }

        //HP�͏���𒴂��ĉ񕜂��Ȃ��悤�ɂ���
        if (HP >= 100)
        {
            HP = 100;
        }

    }
}
