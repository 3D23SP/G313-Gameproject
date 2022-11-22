using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //public int countdownMinutes = 3;

    //�؂�ւ��܂ł̕b���̏����l
    private float countdownSeconds = 5;

    //�\���E�̕b��
    public int fTime = 5;

    //�����E�̕b��
    public int rTime0 = 10;
    public int rTime1 = 9;
    public int rTime2 = 11;

    //�J�E���g�_�E���̃e�L�X�g
    private Text timeText;

    //���\�̃t���O
    public int ChgFlg = 0;

    //���̐��E�̕b���̕ω��t���O
    public int TimeRndFlg = 0;


    private void Start()
    {
        timeText = GetComponent<Text>();
        //countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        //�J�E���g�_�E��
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        //�J�E���g�_�E���̕b���\��
        timeText.text = span.ToString(@"mm\:ss");

        // 0�b�ɂȂ����Ƃ��̏���
        if (countdownSeconds <= 0)
        {            
            //�����E�̕b��
            if(ChgFlg == 0)
            {
                if (TimeRndFlg == 0)
                {
                    countdownSeconds = rTime0;
                    TimeRndFlg = 1;
                }
                else if (TimeRndFlg == 1)
                {
                    countdownSeconds = rTime1;
                    TimeRndFlg = 2;
                }
                else if (TimeRndFlg == 2)
                {
                    countdownSeconds = rTime2;
                    TimeRndFlg = 0;
                }
                ChgFlg = 1;
            }
            //�\���E�̕b��
            else if(ChgFlg == 1)
            {
                countdownSeconds = fTime;
                ChgFlg = 0;
            }
            
        }
    }
}
