using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {

	public GameObject player;
	public int speed;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
	}
}
