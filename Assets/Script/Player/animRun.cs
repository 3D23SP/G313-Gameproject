using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animRun : MonoBehaviour
{
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
            position.x -= spd;                      //���Ɉړ�
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            position.x += spd;                      //�E�Ɉړ�
        }
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            position.y += spd;                      //��Ɉړ�
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            position.y -= spd;                      //���Ɉړ�
        }

        //�ړ����������őҋ@
        if (Input.GetKeyUp("left") || Input.GetKeyUp("a"))
        {
            anim.SetBool("leftStand", true);        //�������őҋ@
        }
        else if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            anim.SetBool("rightStand", true);       //�E�����őҋ@
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("w"))
        {
            anim.SetBool("backStand", true);        //������őҋ@
        }
        else if (Input.GetKeyUp("down") || Input.GetKeyUp("s"))
        {
            anim.SetBool("frontStand", true);       //�O�����őҋ@
        }

        //�A�j���[�V����
        if(Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            anim.SetBool("leftStand", false);       //Stand��ԉ���
            anim.SetBool("rightStand", false);
            anim.SetBool("backStand", false);
            anim.SetBool("frontStand", false);
      
            anim.SetBool("rightRun", false);        //Run��ԉ���
            anim.SetBool("backRun", false);
            anim.SetBool("frontRun", false);

            anim.SetBool("leftRun", true);          //�������Ɉړ��A�j���[�V����
        }
        else if(Input.GetKeyUp("left") || Input.GetKeyUp("a"))
        {
            anim.SetBool("leftRun", false);
        }
        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            anim.SetBool("leftStand", false);       //Stand��ԉ���
            anim.SetBool("rightStand", false);
            anim.SetBool("backStand", false);
            anim.SetBool("frontStand", false);

            anim.SetBool("leftRun", false);         //Run��ԉ���
            anim.SetBool("backRun", false);
            anim.SetBool("frontRun", false);

            anim.SetBool("rightRun", true);         //�E�����Ɉړ��A�j���[�V����
        }
        else if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            anim.SetBool("rightRun", false);
        }
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            anim.SetBool("leftStand", false);       //Stand��ԉ���
            anim.SetBool("rightStand", false);
            anim.SetBool("backStand", false);
            anim.SetBool("frontStand", false);
                            
            anim.SetBool("leftRun", false);         //Run��ԉ���               
            anim.SetBool("rightRun", false);  
            anim.SetBool("frontRun", false);

            anim.SetBool("backRun", true);          //������Ɉړ��A�j���[�V����
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("d"))
        {
            anim.SetBool("backRun", false);
        }
        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
                
            anim.SetBool("leftStand", false);       //Stand��ԉ���               
            anim.SetBool("rightStand", false);               
            anim.SetBool("backStand", false);    
            anim.SetBool("frontStand", false);

                
            anim.SetBool("leftRun", false);         //Run��ԉ���               
            anim.SetBool("rightRun", false);               
            anim.SetBool("backRun", false);

            anim.SetBool("frontRun", true);         //�O�����Ɉړ��A�j���[�V����
        }
        else if (Input.GetKeyUp("down") || Input.GetKeyUp("s"))
        {
            anim.SetBool("frontRun", false);
        }

        transform.position = position;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
