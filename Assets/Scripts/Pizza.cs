using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    private SpriteRenderer pizza;
    private SpriteRenderer door;
    private bool isGrounded = false;
 
    [SerializeField]
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        pizza = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        door = collision.GetComponent<SpriteRenderer>();

        if (pizza.color == door.color)
        {
            Destroy(pizza.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            isGrounded = true;
            Debug.Log("Grounded");
        }
        if (collision.gameObject.CompareTag("Player") && isGrounded)
        {
            Debug.Log("Player collided");
            player = GetComponent<Transform>();
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y +2f, player.transform.position.z);

            isGrounded = false;
        }

}

}

