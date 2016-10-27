using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dialogue : MonoBehaviour {
	public Text label;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void set_Dialogue (string text){ // A modifier avec le pointeur versl e fichier XML à l'endroit du text
		this.label.text = text;
		Debug.Log ("Set le dialogue");
	}
}
