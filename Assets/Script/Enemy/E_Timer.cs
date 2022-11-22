using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Timer : MonoBehaviour
{
    //�؂�ւ��܂ł̕b���̏����l
    public float countdownSeconds = 5;

    //�\���E�̕b��
    public int fTime = 5;

    //�����E�̕b��
    public int rTime0 = 10;
    public int rTime1 = 9;
    public int rTime2 = 11;

    //���\�̃t���O
    public int ChgFlg = 0;

    //���̐��E�̕b���̕ω��t���O
    public int TimeRndFlg = 0;

    private E_Move move;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<E_Move>();
    }

    // Update is called once per frame
    void Update()
    {
        //�J�E���g�_�E��
        countdownSeconds -= Time.deltaTime;

        

        if (countdownSeconds <= 0)
        {
            if (ChgFlg == 0)
            {   
                move.SetAi(true);   
                
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
            else if (ChgFlg == 1)
            {
                //�\���E�̕b��
                countdownSeconds = fTime;                
                ChgFlg = 0;
                move.SetAi(false);
            }
        }
    } 
}
