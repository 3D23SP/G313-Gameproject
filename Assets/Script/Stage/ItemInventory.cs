using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour
{
    //�A�C�e����ۊǂ���ׂ̃C���x���g��
    public GameObject ItemSlot;

    public static ItemInventory instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }
}
