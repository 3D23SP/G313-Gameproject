using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour
{
    //アイテムを保管する為のインベントリ
    public GameObject ItemSlot;

    public static ItemInventory instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }
}
