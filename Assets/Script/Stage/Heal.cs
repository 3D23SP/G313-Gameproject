using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heal : ObjectT
{
    void Update()
    {
        if (ObjectTouch == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HPBar.value += Healing;
                Destroy(HPoint, 0.5f);
                ObjectTouch = false;
            }
        }
    }
}
