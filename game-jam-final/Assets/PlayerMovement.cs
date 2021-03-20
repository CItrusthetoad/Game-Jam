using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	[SerializeField] private LayerMask platformLayerMask;
    Rigidbody2D rb;
	BoxCollider2D boxCollider2d;
	
    // Start is called before the first frame update
    void Start()
    {
       rb = transform.GetComponent<Rigidbody2D>(); 
	   boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
		IsGrounded();
    }
	    void Jump() 
    { 
        if (Input.GetKeyDown(KeyCode.Space) && (IsGrounded())) {
            float jumpVelocity = 10f;
			rb.velocity = Vector2.up * jumpVelocity;
    } 
}
	bool IsGrounded() {
		RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
		return raycastHit2d.collider != null;
	}
}

