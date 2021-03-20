using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    float horizontalMove = 0f;
    public float speed;
    bool crouch = false;
    [SerializeField] private LayerMask platformLayerMask;
    Rigidbody2D rb;
    BoxCollider2D boxCollider2d;
    public float jumpVelocity;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Belarus");
        rb = transform.GetComponent<Rigidbody2D>(); 
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        Jump();
        IsGrounded();

        if(Input.GetButtonDown("Crouch")) 
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        characterController.Move(horizontalMove * Time.fixedDeltaTime, crouch, false);
        
    }

    void Jump() 
    { 
        if (Input.GetKeyDown(KeyCode.W) && (IsGrounded())) {
            rb.velocity = Vector2.up * jumpVelocity;
    } 
    }

     bool IsGrounded() 
     {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return raycastHit2d.collider != null;
    }
}

