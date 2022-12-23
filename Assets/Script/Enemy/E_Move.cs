using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class E_Move : MonoBehaviour
{
    public int destPoint = 0;
    public bool Try = false;
    public Vector2 NextPosition;
    public float EnemyStopTimer;
    public float SpeedX;
    public float SpeedY;
    public Transform[] points; //追跡するターゲット
    public bool isAi;

    private NavMeshAgent2D agent; //NavMeshAgent2Dを使用するための変数
    public Vector2 m_Pos;
    public Vector2 Distance;
    private float distanceX = 2.0f;
    private float distanceY = 2.0f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent2D>(); //agentにNavMeshAgent2Dを取得
        
        Try = false;
        m_Pos = transform.position;
        NextPosition = points[destPoint].position;
        

    }

    private void Update()
    {
        if(!isAi)
        {
            return;
        }

        m_Pos = transform.position;
        
        Distance = NextPosition - new Vector2(transform.position.x, transform.position.y);

        agent.destination = points[destPoint].position;

        if (Dis(Distance.x) <  distanceX && Dis(Distance.y) <  distanceY && !Try)
        {
            

            if (StopTimer())
            {
                GotoNext();
                Try = true;
                EnemyStopTimer = 0.0f;
            }
        }
        else if(Dis(Distance.x) < 5.0f && Dis(Distance.y) < 5.0f  )
        {           
                Try = false;           
        }

        SpeedX = Distance.x;
        SpeedY = Distance.y;
    }


    private void GotoNext()
    {
        if (points.Length == 0)
        {
            return;
        }

        m_Pos= points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;

        agent.destination = points[destPoint].position;


        //destPoint += 1;
        
        
        NextPosition = points[destPoint].position;
    }



    private float Dis(float Distance)
    {
        if (Distance < 0.0f)
        {
            Distance  *= -1;
        }
        return Distance;
    }


    private bool StopTimer()
    {
        EnemyStopTimer += 1;

        if (EnemyStopTimer >= 23.0f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void SetAi(bool SetAi)
    {
        isAi = SetAi;
    }

    public bool CheckAi()
    {
        return isAi;
    }

}
