using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

	public float motionSpeed;
	public float jumpForce;
	bool canJump = true;
	public int health;
	public Text healthUI;
	public GameObject projectile;


	Rigidbody2D rBody;

	// Use this for initialization
	void Start () {
		rBody = GetComponent<Rigidbody2D>();
		health = 3;
		


	}
	
	// Update is called once per frame
	void Update () {



		//jump
		if (Input.GetKeyDown (KeyCode.W) && canJump) {
				//transform.Translate (Vector2.up * Time.deltaTime * motionSpeed);
			rBody.AddForce (new Vector2(rBody.velocity.x, jumpForce));

		}

		if (Input.GetKey(KeyCode.A)) {
			transform.Translate (new Vector2(-motionSpeed,0) * Time.deltaTime);
		}

		//if (Input.GetKey(KeyCode.S)) {
		//	transform.Translate (Vector2.up * Time.deltaTime * speed);
		//}

		if (Input.GetKey(KeyCode.D)) {
			transform.Translate (new Vector2(motionSpeed,0) * Time.deltaTime);
		}

		if (Input.GetMouseButtonDown(0)){
			Instantiate(projectile,transform.position,Quaternion.identity);
		}


		healthUI.text = "Health: " + health;




	}
	
	// OnCollEnter2D is called whenever player touches a collider
	void OnCollisionEnter2D(Collision2D c1) {
		if (c1.gameObject.tag == "ground") {
			canJump = true;
		}

		if (c1.gameObject.tag == "enemy") {
			health--;
			Debug.Log ("i lost a health");
			if (health == 0) {
				Destroy (gameObject);
			}
		}
	}

	void OnCollisionExit2D(Collision2D c1) {
		if (c1.gameObject.tag == "ground") {
			canJump = false;
		}
		
	}
}



		
		

