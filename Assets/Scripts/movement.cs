using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float cameraX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(0,0,10*Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(0,0,-10f*Time.deltaTime);
			}
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.eulerAngles += new Vector3 (0, 90f, 0);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.eulerAngles += new Vector3 (0, -90f, 0);
		}

		Camera.main.transform.position=transform.position + new Vector3(0,2f,-3f);

	}
}
