using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Player functionallity goes here.
	private string playerName;

	public void Start(){
		playerName = "ThePlayer";
		Debug.Log ("Hello, this is the player from player: " + GetPlayerName());
	}

	public string GetPlayerName(){
		return playerName;
	}
}
