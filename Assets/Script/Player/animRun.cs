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

        //キャラクター移動
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            spdX -= spd;                        //左に移動            
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            spdX += spd;                        //右に移動            
        }
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            spdY += spd;                        //上に移動            
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            spdY -= spd;                        //下に移動
        }

        //アニメーション
        if (spdX > 0)
        {
            StandFalse();                       //Stand状態解除
            RunFalse();                         //Run状態解除
            anim.SetBool("rightRun", true);
        }
        if (spdX < 0)
        {
            StandFalse();                       //Stand状態解除
            RunFalse();                         //Run状態解除
            anim.SetBool("leftRun", true);
        }
        if (spdY > 0)
        {
            StandFalse();                       //Stand状態解除
            RunFalse();                         //Run状態解除
            anim.SetBool("backRun", true);
        }
        if (spdY < 0)
        {
            StandFalse();                       //Stand状態解除
            RunFalse();                         //Run状態解除
            anim.SetBool("frontRun", true);
        }

        if (spdX == 0.0f && spdY == 0.0f)
        {
            StandTrue();                        //Stand状態オン
            RunFalse();                         //Run状態解除
        }

        position.x += spdX;
        position.y += spdY;

        transform.position = position;

        spdX = 0.0f;
        spdY = 0.0f;

    }

    //ゲームオーバー画面へ
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    //Stand状態解除
    private void StandFalse()
    {
        anim.SetBool("leftStand", false);
        anim.SetBool("rightStand", false);
        anim.SetBool("backStand", false);
        anim.SetBool("frontStand", false);
    }

    //Stand状態オン
    private void StandTrue()
    {
        anim.SetBool("leftStand", true);
        anim.SetBool("rightStand", true);
        anim.SetBool("backStand", true);
        anim.SetBool("frontStand", true);
    }

    //Run状態解除
    private void RunFalse()
    {
        anim.SetBool("rightRun", false);
        anim.SetBool("leftRun", false);
        anim.SetBool("backRun", false);
        anim.SetBool("frontRun", false);
    }
}