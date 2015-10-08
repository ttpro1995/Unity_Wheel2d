using UnityEngine;
using System.Collections;

public class DragWithVelocity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	private Vector3 applePos;
	private Vector3 lastPos;
	private Vector3 delta;
	private float distance;
	private float speed;
	public int rollnow_speed;
	void FixedUpdate () {
		if ( Input.GetMouseButtonDown(0) )
		{// first frame where user click
			lastPos = Input.mousePosition;//get last frame position
		}
		else if ( Input.GetMouseButton(0) )
		{
			speed = 0;
			//calculate position speed


			//point on screen
			//ScreenPointLast = Camera.main.WorldToScreenPoint(lastPos);
			//ScreenPointNew = Camera.main.WorldToScreenPoint(Input.mousePosition);
			print("Last = "+lastPos.x+" "+lastPos.y+" "+lastPos.z+" ");
			print("New = "+ Input.mousePosition.x+" "+Input.mousePosition.y+" "+Input.mousePosition.z+" ");



			//raw speed
			//speed = distance / Time.deltaTime;
			//Debug.Log("speed = "+speed);
		

			//move horizontal
			//if(delta_x<0) {
			//	speed = -speed;
			//}

			//x part
			float delta_x = lastPos.x - Input.mousePosition.x;//get delta x
			print ("deltax = "+delta_x);

			float speed_x = delta_x/Time.deltaTime; // speed in x direction
			 

			if (lastPos.y < Screen.height/2) {//get angular speed of apple
				speed_x = -speed_x;//bottom half 
			}
			speed = speed_x + speed;//add to total speed

			//y part
			float delta_y = lastPos.y - Input.mousePosition.y;
			float speed_y = delta_y/Time.deltaTime;//speed in y direction

			if (lastPos.x > Screen.width/2) {
				speed_y = -speed_y;//right half
			}
			speed = speed + speed_y;

			//
			speed = speed * 2 / 3;//slow down a bit

			//
			GetComponent<Rigidbody2D> ().angularVelocity = speed;

			
			lastPos = Input.mousePosition;
		}
	}

	public void rollNow(){
		GetComponent<Rigidbody2D> ().angularVelocity = rollnow_speed;
	}
}
