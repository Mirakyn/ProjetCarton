using UnityEngine;
using System.Collections;

public class Caracter_HUD : MonoBehaviour {
	private Vector3 translation;

	// Use this for initialization
	void Start () {
		translation = new Vector3 (60, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void move_Outside(){
		transform.Translate (-translation.x,
			translation.y,
			translation.z);
	}

	public void move_Inside(){
		transform.Translate (translation.x,
			translation.y,
			translation.z);
	}
}
