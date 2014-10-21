using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {
	
	public GameObject player;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//android touch
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
		{
			Vector2 touchPosition = Input.GetTouch(0).position;
			double halfScreen = Screen.width / 2.0;
			
			//Check if it is left or right?
			if(touchPosition.x < halfScreen){
				player.transform.Translate(Vector3.left * 5 * Time.deltaTime);
			} else if (touchPosition.x > halfScreen) {
				player.transform.Translate(Vector3.right * 5 * Time.deltaTime);
			}
			
		}
		//keyboard
		if (Input.GetKeyDown(KeyCode.A))
		{
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			Vector3 position = this.transform.position;
			position.y--;
			this.transform.position = position;
		}
	}
}