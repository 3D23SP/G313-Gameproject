using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMBulleta : MonoBehaviour
{
    public GameObject player;
    public GameObject ItemPanel;
    public GameObject Ekey;
    public GameObject GunPos;
    public GameObject TeaPos;
    public GameObject BloodPos;
    public GameObject MercuryPos;
    public GameObject ItemSprite;
    public bool eFlg;

    public bool contactFlg;

    // Start is called before the first frame update
    void Start()
    {
        eFlg = false;
        contactFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(contactFlg == true)
        {
            if(eFlg == false)
            {
                Ekey.SetActive(true);
            }            
            if (Input.GetKeyDown("e"))
            {
                ItemPanel.SetActive(true);
                eFlg = true;
                Ekey.SetActive(false);
                GunPos.SetActive(true);
                TeaPos.SetActive(true);
                BloodPos.SetActive(true);
                MercuryPos.SetActive(true);
                ItemSprite.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            contactFlg = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        contactFlg = false;
        Ekey.SetActive(false);
    }
}
