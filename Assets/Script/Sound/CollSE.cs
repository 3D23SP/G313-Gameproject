using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollSE : MonoBehaviour
{
    // Start is called before the first frame update
�@// �ϐ��ݒ�
    public AudioClip se;
    public AudioClip se1;

    AudioSource audioSource1;
    AudioSource audioSource2;
    void Start()
    {
        //���ꂼ��Ή�����AudioSoure�ɑ��
        audioSource1 = gameObject.GetComponent<AudioSource>();
        audioSource1.clip = se;

        audioSource2 = gameObject.GetComponent<AudioSource>();
        audioSource2.clip = se1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�G�ꂽ���̂̎�ނŉ���炷�B
        if(collision.gameObject.CompareTag("CC"))
        {
            audioSource1.PlayOneShot(se);
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.CompareTag("CT"))
        {
            audioSource2.PlayOneShot(se1);
           // collision.gameObject.SetActive(false);
        }
    }
}
