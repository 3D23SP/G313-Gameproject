using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    //フェードキャンバスの取得
    [SerializeField] private Fade fade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Fade();
        }
    }

    public void Fade()
    {
        fade.FadeIn(1f, () =>
        {
            fade.FadeOut(1f);
        });
    }
}
