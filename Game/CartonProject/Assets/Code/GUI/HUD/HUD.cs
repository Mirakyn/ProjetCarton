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
	private GameObject dialogues;

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

	public void text_State (){
		//Penser a rajouter le pointeur vers le texte a allé lire ne XML pour l'afficher au fur et a mesure (a laisser gérer par le HUD)
		set_Visible (false);

		dialogues = (GameObject) Instantiate (Resources.Load("GUI/dialogue_HUD"));

	}


}
