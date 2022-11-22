using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class E_Respawn : MonoBehaviour
{
    public Transform[] m_points; //リスポーン地点
    public Transform Enemy;
    //public Transform m_PlayerPos;
    public float Distance;
    public int m_RespawnPoint;


    private bool m_bRespawn;
    public float m_StraightX;
    public float m_StraightY;

    private E_Move move;


    // Start is called before the first frame update
    private void Start()
    {
        move = GetComponent<E_Move>();

        SetRespawn();
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (!move.CheckAi())
        {
            SetRespawn();
            return;
        }
        if (Input.GetKeyDown("space"))
        {
            m_bRespawn = !m_bRespawn;
            
        }

        if (m_bRespawn)
        {
            SetRespawn();
            m_bRespawn = !m_bRespawn;
        }

    }


    private void SetRespawmPoint()
    {
        m_RespawnPoint = Random.Range(0, m_points.Length);        
    }

    private void ResetRespawmPoint()
    {
       m_RespawnPoint += 1;

        if (m_RespawnPoint > m_points.Length)
        {
            m_RespawnPoint = 1;
        }

    }



    private void Dis(float DisaX,float DisaY)
    {
        if (DisaX < 0.0f)
        {
            DisaX *= -1;
        }
        if (DisaY < 0.0f)
        {
            DisaY *= -1;
        }

        m_StraightX = DisaX;
        m_StraightY = DisaY;
    }   

    //リスポーン地点設定
    private void SetPosition()
    {
        Enemy.position = m_points[m_RespawnPoint].position;        
    }

    //リスポーン全体設定
    private void SetRespawn()
    {
        SetRespawmPoint();
        SetPosition();       
    }
}
