using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float playerSpeed;
	public GUIText cat_count_text;

	private Rigidbody2D controller;
	private int cat_count;



	void Start ()
	{
		controller = gameObject.GetComponent<Rigidbody2D> ();
		cat_count = 0;
		SetCatCountText ();
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
			cat_count = cat_count + 1;
			SetCatCountText ();
		}
	}

	void SetCatCountText()
	{
		cat_count_text.text = "Cats Captured: " + cat_count.ToString();
	}
}
