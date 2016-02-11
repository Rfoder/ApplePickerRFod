using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {


	public GameObject 	applePrefab;

	public float 	speed = 1f;

	public float 	leftAndRightEdge = 10f;

	public float 	chanceToChangeDirections = 0.1f;

	public float 	secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
	
		//Drop apples every seconds
		InvokeRepeating( "DropApple", 2f, secondsBetweenAppleDrops );
	
	}

	void DropApple() {
		GameObject apple = Instantiate ( applePrefab ) as GameObject;
		apple.transform.position = transform.position;
	}
	// Update is called once per frame

	void Update () {
		//basic movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		//change directions

		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed); //right
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed); // left
		}

	}

	void FixedUpdate() {
		//randomly change direction
		 if (Random.value < chanceToChangeDirections) {
			speed *= -1; // change direction
	      }
		}

    }

	
	

