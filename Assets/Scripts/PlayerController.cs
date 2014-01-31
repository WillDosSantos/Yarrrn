using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float playerSpeed;

	private Rigidbody2D controller;

	void Start ()
	{
		controller = gameObject.GetComponent<Rigidbody2D> ();
		
	}

	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector2 movement = new Vector2 (moveHorizontal, 0.0f);

		controller.AddForce (movement * playerSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "cat") 
		{
			other.gameObject.SetActive(false);
		}
	}
}
