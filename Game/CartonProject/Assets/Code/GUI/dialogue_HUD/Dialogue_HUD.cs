using UnityEngine;
using System.Collections;

public class Dialogue_HUD : MonoBehaviour {
	private Speaker_Name speaker;
	private Dialogue dialogue;
	private HUD parent;

	// Use this for initialization
	void Start () {
		//Used lately. It makes so problems because we use its function before Start()
		//speaker = GetComponentInChildren<Speaker_Name> ();
		//dialogue = GetComponentInChildren<Dialogue> ();
		parent = FindObjectOfType<HUD> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			FindObjectOfType<HUD> ().exit_Dialogue ();
		}
	}

	public void set_Dialogue_Tree (Unit unit, string text){ // A modifier avec le pointeur vers le fichier XML à l'endroit du text
		speaker = GetComponentInChildren<Speaker_Name> ();
		dialogue = GetComponentInChildren<Dialogue> ();

		speaker.set_Name_Speaker (unit.get_Name ());
		dialogue.set_Dialogue (text);
	}

	/**
	 * Destroy all child of the dialogue_HUD
	 */
	public void destroy_Child (){
		foreach (Transform child in transform) {
			GameObject.Destroy (child.gameObject);
		}
	}
}
