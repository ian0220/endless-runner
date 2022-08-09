using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovment : MonoBehaviour
{
    [SerializeField]
    private FlyWayWalk m_data;
    private float m_speed;
    [SerializeField]
    private Rigidbody m_RB;
    private MapGeneretorMain m_gen;
    private PoolItem poolitem;
    [SerializeField]
    private BackGround m_backGround;
    void Start()
    {
        m_gen = FindObjectOfType<MapGeneretorMain>();
        m_RB = GetComponent<Rigidbody>();
        m_speed = m_data.Speed;
        poolitem = GetComponent<PoolItem>();
        
    } 


    void Update()
    {  // ik roep de rb aan om de dingen te laten be wegen in een konstante beweging naar links gaat de - kant op op de x as
        m_RB.MovePosition(Vector3.zero + new Vector3(transform.position.x + -m_speed * Time.deltaTime, transform.position.y, transform.position.z)); 

        if(transform.position.x <= -35) // controleerd voor de normale objecten zo als de vloer en de enemys en currency en zet het terug naar object pool
        {   
            if(gameObject.GetComponent<PoolItem>())
            {
                poolitem.ReturnToPool();
            }
           
            if(gameObject.GetComponent<FloorTag>())
            {
                m_gen.nextspawn();
                Destroy(gameObject);
            }
        }

        if(transform.position.x <= -110)// doet de back ground achter de achterste 
        {
            m_backGround.moeftoo(gameObject);
        }
    }
}
