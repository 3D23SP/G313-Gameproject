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

        //キャラクター移動
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            position.x -= spd;                      //左に移動
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            position.x += spd;                      //右に移動
        }
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            position.y += spd;                      //上に移動
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            position.y -= spd;                      //下に移動
        }

        //移動した向きで待機
        if (Input.GetKeyUp("left") || Input.GetKeyUp("a"))
        {
            anim.SetBool("leftStand", true);        //左向きで待機
        }
        else if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            anim.SetBool("rightStand", true);       //右向きで待機
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("w"))
        {
            anim.SetBool("backStand", true);        //後向きで待機
        }
        else if (Input.GetKeyUp("down") || Input.GetKeyUp("s"))
        {
            anim.SetBool("frontStand", true);       //前向きで待機
        }

        //アニメーション
        if(Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            anim.SetBool("leftStand", false);       //Stand状態解除
            anim.SetBool("rightStand", false);
            anim.SetBool("backStand", false);
            anim.SetBool("frontStand", false);
      
            anim.SetBool("rightRun", false);        //Run状態解除
            anim.SetBool("backRun", false);
            anim.SetBool("frontRun", false);

            anim.SetBool("leftRun", true);          //左向きに移動アニメーション
        }
        else if(Input.GetKeyUp("left") || Input.GetKeyUp("a"))
        {
            anim.SetBool("leftRun", false);
        }
        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            anim.SetBool("leftStand", false);       //Stand状態解除
            anim.SetBool("rightStand", false);
            anim.SetBool("backStand", false);
            anim.SetBool("frontStand", false);

            anim.SetBool("leftRun", false);         //Run状態解除
            anim.SetBool("backRun", false);
            anim.SetBool("frontRun", false);

            anim.SetBool("rightRun", true);         //右向きに移動アニメーション
        }
        else if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            anim.SetBool("rightRun", false);
        }
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            anim.SetBool("leftStand", false);       //Stand状態解除
            anim.SetBool("rightStand", false);
            anim.SetBool("backStand", false);
            anim.SetBool("frontStand", false);
                            
            anim.SetBool("leftRun", false);         //Run状態解除               
            anim.SetBool("rightRun", false);  
            anim.SetBool("frontRun", false);

            anim.SetBool("backRun", true);          //後向きに移動アニメーション
        }
        else if (Input.GetKeyUp("up") || Input.GetKeyUp("d"))
        {
            anim.SetBool("backRun", false);
        }
        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
                
            anim.SetBool("leftStand", false);       //Stand状態解除               
            anim.SetBool("rightStand", false);               
            anim.SetBool("backStand", false);    
            anim.SetBool("frontStand", false);

                
            anim.SetBool("leftRun", false);         //Run状態解除               
            anim.SetBool("rightRun", false);               
            anim.SetBool("backRun", false);

            anim.SetBool("frontRun", true);         //前向きに移動アニメーション
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
