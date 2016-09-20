using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class sunken : MonoBehaviour {
	public bool monsterZone=false;
	public Transform player;
	public Transform sunkenShip;
	public Transform mountain;
	public Transform monster;
	public Text gameText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((sunkenShip.position-player.position).magnitude<10f){
			gameText.text = "You found a sunken pirate ship that left behind a map. \n Unlucky for them, lucky for you. Anyways, it says head west and look for Mount Convenience.";
		}
		if (player.position.x-mountain.position.x<Mathf.Abs(10f)){
			gameText.text = "Convenience spotted, sailor! The map says to head south-east and fight a mysterious sea monster. Sounds dangerous!";
			monsterZone = true;
		}
		if (monster.position.z-player.position.z>12f){
			gameText.text = "Turns out the monster was totally non-confrontational! Who woulda guessed? Looking at the map, you come to understand that all there's left to do is head north-east and you'll find the treasure chest!";

		}
		if(player.position.x-monster.position.x>5f&&monsterZone==true){
			gameText.text = "Looks like you're heading a bit too far east, sailor.";
		}
	}
}
