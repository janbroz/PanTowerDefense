using UnityEngine;
using System.Collections;

public class Unit : BasicObject {

	private int movementSpeed;

	protected override void Start ()
	{
		base.Start ();
		objectName = "Unit000";
		movementSpeed = 2;
		Debug.Log ("Hello, this is: " + objectName);
	}

	protected override void Update ()
	{
		base.Update ();
		Walk ();
	}

	private void Walk(){
		gameObject.transform.Translate(Time.deltaTime * movementSpeed, 0,0);
	}


}
