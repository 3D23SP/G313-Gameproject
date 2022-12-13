using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject StartRoomGrid;
    public Grid EnemyGrid;

    public GameObject PlayerPoint;    
    public GameObject EnemyResPoint;
    public GameObject EnemyMapSetting;
    // Start is called before the first frame update
    void Start()
    {
        StartRoomGrid.SetActive(true);
        EnemyGrid.gameObject.SetActive(true);

        PlayerPoint.SetActive(true);
        EnemyResPoint.SetActive(true);
        EnemyMapSetting.SetActive(true);
    }

    
}
