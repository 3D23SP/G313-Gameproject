using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPGM : MonoBehaviour
{
    //Slider�R���|�[�l���g���Ǘ�����
    public  Slider HPBar;
    //HP���`
    public int HP = 100;
    //���t���[���_���[�W�Ɏ��ԊԊu��ݒ肷��
    public float time = 0.0f;

    //ObjectT�X�N���v�g�ɂ�����I�u�W�F�N�g�Փ˔���
    public bool ObjectT = false;
    //�񕜃I�u�W�F�N�g�g�p���ɉ񕜂���HP��
    public int Healing = 10;
    //�e�L�X�g�\���p�I�u�W�F�N�g�̒�`
    public GameObject HMFrame;
    //�񕜂ł���I�u�W�F�N�g�̒�`
    public GameObject HealObject;


    void Start()
    {

    }
    void Update()
    {

    }
}
