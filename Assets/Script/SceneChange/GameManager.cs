using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Grid MapGrid;
    public Grid EnemyGrid;

    public GameObject PlayerPoint;    
    public GameObject EnemyResPoint;
    public GameObject EnemyMapSetting;
    // Start is called before the first frame update
    void Start()
    {
        MapGrid.gameObject.SetActive(true);
        EnemyGrid.gameObject.SetActive(true);

        PlayerPoint.SetActive(true);
        EnemyResPoint.SetActive(true);
        EnemyMapSetting.SetActive(true);
    }

    
}
