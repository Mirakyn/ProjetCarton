using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speaker_Name : MonoBehaviour {
	public Text label;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void set_Name_Speaker (string name){
		this.label.text = name + ": ";
		Debug.Log ("Set le nom du speaker");
	}
}
