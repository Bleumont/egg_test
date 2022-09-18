using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector2 m_Position;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        m_Position = transform.position;    
        m_Position.x = player.position.x;
        m_Position.y = player.position.y +2;


        transform.position = m_Position;
    }
}
