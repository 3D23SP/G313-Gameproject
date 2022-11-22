using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeWarp : MonoBehaviour
{
    //���֐؂�ւ���
    //public int countdownMinutes = 3;

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

    //�ړ���̍��W  
    private Vector3 target;

    //�L�����N�^�[�̕\�����W�擾
    public Vector2 warpPoint;

    //�������_���X�|�[��
    public Transform[] rsPos;

    private FadeInOut fadeInOut;

    public bool fa;

    

    private void Start()
    {
        //countdownSeconds = countdownMinutes * 60;
        fa = false;
        fadeInOut = GetComponentInChildren<FadeInOut>();
    }

    void Update()
    {
        //�J�E���g�_�E��
        countdownSeconds -= Time.deltaTime;
        Transform Transform = this.transform;
        Vector2 Pos = Transform.position;

        if (!fa)
        {
            if (countdownSeconds <= 2.0f)
            {
                fa = true;
            }
        }
        else if (fa)
        {
            fadeInOut.Fade();
            fa = false;
        }
        

        // 0�b�ɂȂ����Ƃ��̏���
        if (countdownSeconds <= 0)
        {
            if (ChgFlg == 0)
            {
                //�\���E�̍��W�ۑ�
                warpPoint.x = Pos.x;
                warpPoint.y = Pos.y;

                //�����E�̕b��
                if (TimeRndFlg == 0)
                {
                    
                    countdownSeconds = rTime0;
                    TimeRndFlg = 1;
                }
                else if(TimeRndFlg == 1)
                {
                    
                    countdownSeconds = rTime1;
                    TimeRndFlg = 2;
                }
                else if(TimeRndFlg == 2)
                {
                    
                    countdownSeconds = rTime2;
                    TimeRndFlg = 0;
                }

                //�����E�X�|�[�������_���ݒ�
                int rnd = Random.Range(0, 5);
                gameObject.transform.position = rsPos[rnd].position;
                ChgFlg = 1;
            }            
            else if (ChgFlg == 1)
            {
                //�\���E�̕b��
                countdownSeconds = fTime;
                //target = gameObject.transform.position;
                target.x = warpPoint.x;
                target.y = warpPoint.y;
                gameObject.transform.position = target;
                ChgFlg = 0;
            }
        }
    }

   
}
