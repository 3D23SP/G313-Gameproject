using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeTea : MonoBehaviour
{
    public GameObject player;
    public GameObject Tea;
    public GameObject Ekey;
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
        if (contactFlg == true)
        {
            if (eFlg == false)
            {
                Ekey.SetActive(true);
            }
            if (Input.GetKeyDown("e"))
            {
                Tea.SetActive(true);
                eFlg = true;
                Ekey.SetActive(false);
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
