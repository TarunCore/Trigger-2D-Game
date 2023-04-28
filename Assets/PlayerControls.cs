using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
	public Rigidbody2D rb;
	GameObject Spirite;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool onGround;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();

		}
	
	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector2 (5, rb.velocity.y);

		onGround = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (Input.GetMouseButton (0) && onGround) {
			rb.velocity = new Vector2 (4, rb.velocity.x);
		}

		if (Input.GetMouseButton (1) && onGround) {
			rb.velocity = new Vector2 (8, rb.velocity.x);
		}
	}
}
