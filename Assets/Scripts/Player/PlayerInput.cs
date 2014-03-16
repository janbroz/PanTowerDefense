using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	private Player player;

	// All of the user input should be managed here.
	public void Start(){
		player = GameObject.Find ("Player").GetComponent <Player>();
		Debug.Log ("Hello, this is the player from playerinput: " + player.GetPlayerName());
	}

}
