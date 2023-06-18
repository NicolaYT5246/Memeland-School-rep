using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float jumpForce = 10f;
	private Rigidbody rb;
	private Animator anim;
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	private void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal")*moveSpeed;
		float vertical = Input.GetAxis("Vertical")*moveSpeed;
		Vector3 movement = new Vector3(horizontal, 0f, vertical);
		rb.AddForce(movement);
		if(Input.GetKeyDown(KeyCode.Space))
		{
            rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
		}


	}
	public void SpeedForc(float speed)
	{
		moveSpeed = moveSpeed + speed;
	}

	public void JumpForc(float jump)
	{
		jumpForce = jumpForce + jump;
	}
}