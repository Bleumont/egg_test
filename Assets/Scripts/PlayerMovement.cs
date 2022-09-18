using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D player;
    public float moveSpeed;
    public float jumpForce = 1f;
    private float movementDirection;
    private bool isGrounded = true;
    private string GROUND_TAG = "Piso";


    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement()
    {
        movementDirection = Input.GetAxisRaw("Horizontal");
        player.position += new Vector2( movementDirection , 0) * Time.deltaTime * moveSpeed;

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            player.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
        }
    }
}
