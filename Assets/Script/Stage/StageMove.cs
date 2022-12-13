using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMove : MonoBehaviour
{
    public GameObject player;    
    public GameObject NextObject;
    public GameObject Map;
    public GameObject NextMap;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            player.transform.position = NextObject.transform.position;

            Map.SetActive(false);
            NextMap.SetActive(true);
            
        }
    }
}
