using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameLogic : MonoBehaviour {
	bool didPlayerWin=false;
	public Text gameText;
	public Transform player;
	public Transform treasure;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (didPlayerWin) {
			gameText.text = "Shiver me timbers, you did it you scallywag!";
		}
		else if((player.position-treasure.position).magnitude<5f){
			gameText.text="Press [SPACE] to collect your dubloons!";
			if(Input.GetKeyDown(KeyCode.Space)){
				didPlayerWin=true;
			}
		}
			}
	}

