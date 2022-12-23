using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animRun : MonoBehaviour
{
    private float spdX;
    private float spdY;

    public float spd = 0.03f;
    Transform tf;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        //�L�����N�^�[�ړ�
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            spdX -= spd;                        //���Ɉړ�            
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            spdX += spd;                        //�E�Ɉړ�            
        }
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            spdY += spd;                        //��Ɉړ�            
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            spdY -= spd;                        //���Ɉړ�
        }

        //�A�j���[�V����
        if (spdX > 0)
        {
            StandFalse();                       //Stand��ԉ���
            RunFalse();                         //Run��ԉ���
            anim.SetBool("rightRun", true);
        }
        if (spdX < 0)
        {
            StandFalse();                       //Stand��ԉ���
            RunFalse();                         //Run��ԉ���
            anim.SetBool("leftRun", true);
        }
        if (spdY > 0)
        {
            StandFalse();                       //Stand��ԉ���
            RunFalse();                         //Run��ԉ���
            anim.SetBool("backRun", true);
        }
        if (spdY < 0)
        {
            StandFalse();                       //Stand��ԉ���
            RunFalse();                         //Run��ԉ���
            anim.SetBool("frontRun", true);
        }

        if (spdX == 0.0f && spdY == 0.0f)
        {
            StandTrue();                        //Stand��ԃI��
            RunFalse();                         //Run��ԉ���
        }

        position.x += spdX;
        position.y += spdY;

        transform.position = position;

        spdX = 0.0f;
        spdY = 0.0f;

    }

    //�Q�[���I�[�o�[��ʂ�
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    //Stand��ԉ���
    private void StandFalse()
    {
        anim.SetBool("leftStand", false);
        anim.SetBool("rightStand", false);
        anim.SetBool("backStand", false);
        anim.SetBool("frontStand", false);
    }

    //Stand��ԃI��
    private void StandTrue()
    {
        anim.SetBool("leftStand", true);
        anim.SetBool("rightStand", true);
        anim.SetBool("backStand", true);
        anim.SetBool("frontStand", true);
    }

    //Run��ԉ���
    private void RunFalse()
    {
        anim.SetBool("rightRun", false);
        anim.SetBool("leftRun", false);
        anim.SetBool("backRun", false);
        anim.SetBool("frontRun", false);
    }
}