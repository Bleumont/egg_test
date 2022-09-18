using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 4f;
    

    // Start is called before the first frame update
    void Start()
    {
        //target = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!target)
        {
            return;
        }
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pizza"))
        {
            Destroy(collision.gameObject);
            target = null;
        }
    }
}
