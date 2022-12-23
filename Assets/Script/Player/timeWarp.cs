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

    public GameObject[] NextMap;

    private FadeInOut fadeInOut;

    public bool fa;

    //�J�E���g�_�E���J�n�t���O
    public bool sFlg;
    //�t���[���[�h�t���O
    public bool fFlg;
    //�J�E���g�_�E���J�n�ʒu
    private Vector3 STarget;
    //�J�E���g�_�E���L�����o�X
    public GameObject Timer;
    //�G�l�~�[
    public GameObject Enemy;
    //�t���[���[�h�L�����o�X
    public GameObject FreeMode;
    //�t�F�[�h�C���A�E�g�L�����o�X
    public GameObject Fade;
    //�A�C�e���L�����o�X
    public GameObject Item;
    //HP�o�[�t���O�p�̃I�u�W�F�N�g
    public GameObject HPBarFlg;

    private void Start()
    {
        //countdownSeconds = countdownMinutes * 60;
        fa = false;
        sFlg = false;
        fFlg = true;
        Fade.SetActive(true);
        Item.SetActive(true);
        fadeInOut = GetComponentInChildren<FadeInOut>();
    }

    void Update()
    {
        if(Input.GetKeyDown("1") && fFlg == true)
        {
            fFlg = false;
            FreeMode.SetActive(true);
            Enemy.SetActive(false);
            Timer.SetActive(false);
        }
        else if(Input.GetKeyDown("1") && fFlg == false)
        {
            fFlg = true;
            FreeMode.SetActive(false);
        }
        //�J�E���g�_�E��
        if (sFlg == true && fFlg == true)
        {
            Enemy.SetActive(true);
            Timer.SetActive(true);

            countdownSeconds -= Time.deltaTime;
        }
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
                NextMap[rnd].SetActive(true);
                ChgFlg = 1;
                HPBarFlg.SetActive(true);
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
                HPBarFlg.SetActive(false);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        STarget = other.gameObject.transform.position;
        sFlg = true;
    }

}
