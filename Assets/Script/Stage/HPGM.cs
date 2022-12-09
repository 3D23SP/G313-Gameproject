using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPGM : MonoBehaviour
{
    //Slider�R���|�[�l���g���Ǘ�����
    public Slider HPBar;
    //HP���`
    public int HP = 1000;
    //���t���[���_���[�W�Ɏ��ԊԊu��ݒ肷��
    double time = 0.0f;
    //ObjectT�X�N���v�g�ɂ�����I�u�W�F�N�g�Փ˔���
    public bool ObjectTouch = false;
    //�񕜃I�u�W�F�N�g�g�p���ɉ񕜂���HP��
    public int Healing = 100;

    void Start()
    {
        //HP�o�[���擾
        HPBar = GameObject.Find("HPBar").GetComponent<Slider>();
        //HP�o�[�̍ő�l��1000�ɂ���
        HPBar.maxValue = 1000;
        //HP�̏����l���ő�l�ɐݒ肷��
        HPBar.value = 1000;
    }
    void Update()
    {
        //1�b���Ƃɓ����̏������s��
        time += Time.deltaTime;
        if (time >= 0.5f)
        {
            //���t���[��1�_���[�W���炤
            HPBar.value -= 1;
            time = 0.0f;
        }
    }
}
