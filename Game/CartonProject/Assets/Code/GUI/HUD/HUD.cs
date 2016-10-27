using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	//Attributes
	[SerializeField]
	private bool visible;

	// Associate the differents part of the HUD
	private Canvas canvas;
	private Ally_HUD ally_HUD;
	private Caracter_HUD caracter_HUD;
	private Pointer_HUD pointer_HUD;
	private Dialogue_HUD dialogues;

	// Use this for initialization
	void Start () {
		visible = true;

		canvas = GetComponent<Canvas> ();

		ally_HUD = GetComponentInChildren<Ally_HUD> ();
		caracter_HUD = GetComponentInChildren<Caracter_HUD> ();
		pointer_HUD = GetComponentInChildren<Pointer_HUD> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Je suis la");
	}

	public void set_Visible (bool visible){
		if (this.visible != visible){
			this.visible = visible;
			if (this.visible) {
				ally_HUD.move_Outside();
				caracter_HUD.move_Outside();
				pointer_HUD.move_Outside();
			}

			else{
				ally_HUD.move_Inside();
				caracter_HUD.move_Inside();
				pointer_HUD.move_Inside();
			}
		}
			
	}

	public void text_State (Unit unit, string text){
		//Penser a rajouter le pointeur vers le texte a allé lire ne XML pour l'afficher au fur et a mesure (a laisser gérer par le HUD)
		if (dialogues == null) {
			set_Visible (false);

			GameObject d = (GameObject)Instantiate (Resources.Load ("GUI/Dialogue_HUD"));
			dialogues = GameObject.FindObjectOfType<Dialogue_HUD> ();

			dialogues.set_Dialogue_Tree (unit, text);
		} else {
			dialogues.set_Dialogue_Tree (unit, text);
		}

	}

	public void exit_Dialogue (){
		if (dialogues != null) {
			Debug.Log ("debut destroying");
			//Destroy child of dialogue_HUD and finally dialogue_HUD himself
			dialogues.destroy_Child();
			GameObject.Destroy (dialogues.gameObject);

			set_Visible (true);
			Debug.Log ("fin destroying");
		}

	}

}
