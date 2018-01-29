using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilescript : MonoBehaviour {
	public int bulletSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2(bulletSpeed,0) * Time.deltaTime);
	}
}
