using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSlot : MonoBehaviour
{
    public bool testG;
    public bool testBl;
    public bool testT;
    public bool testM;

    public GameObject Gun;
    public GameObject Blood;
    public GameObject Tea;
    public GameObject Mercury;
    public GameObject ItemPanel;

    void Start()
    {
        testG = false;
        testBl = false;
        testT = false;
        testM = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2") && testG == false)
        {
            Gun.SetActive(true);
            testG = true;
        }
        else if(Input.GetKeyDown("2") && testG == true)
        {
            Gun.SetActive(false);
            testG = false;
        }
        if (Input.GetKeyDown("3") && testBl == false)
        {
            Blood.SetActive(true);
            testBl = true;
        }
        else if (Input.GetKeyDown("3") && testBl == true)
        {
            Blood.SetActive(false);
            testBl = false;
        }
        if (Input.GetKeyDown("4") && testT == false)
        {
            Tea.SetActive(true);
            testT = true;
        }
        else if (Input.GetKeyDown("4") && testT == true)
        {
            Tea.SetActive(false);
            testT = false;
        }
        if (Input.GetKeyDown("5") && testM == false)
        {
            Mercury.SetActive(true);
            testM = true;
        }
        else if (Input.GetKeyDown("5") && testM == true)
        {
            Mercury.SetActive(false);
            testM = false;
        }
        if(Input.GetKeyDown("6"))
        {
            ItemPanel.SetActive(true);
        }
    }
}
