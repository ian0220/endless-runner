using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private int m_Position;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_Position = 1;
    }
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (m_Position < 0)
        {
            m_Position = 0;
        }

        if (m_Position > 2)
        {
            m_Position = 2;
        }

        if (Input.GetKeyDown(KeyCode.S) && m_Position > 0 && !Menu.GameIsPaused)
        {
            m_Position += -1;
            transform.position = new Vector3(transform.position.x, transform.position.y - 4, transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.W) && m_Position < 2 && !Menu.GameIsPaused)
        {
            m_Position += 1;
            transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
        }
    }
}
