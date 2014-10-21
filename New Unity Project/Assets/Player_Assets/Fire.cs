using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fire : MonoBehaviour {

	//Bullet Fired
	public Transform bulletPrefab;
	public Transform Gun_Main;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Fire bullet
		FireBullet();
	}

	public void FireBullet(){
		GameObject clone = Instantiate(bulletPrefab, GameObject.Find("Gun_Main").transform.position, Quaternion.identity) as GameObject;
		clone.rigidbody.AddForce(Vector3.up * 500);
	}
}
