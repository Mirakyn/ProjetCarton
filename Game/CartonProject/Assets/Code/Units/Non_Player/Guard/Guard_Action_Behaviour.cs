﻿using UnityEngine;
using System.Collections;

public class Guard_Action_Behaviour : Non_Player_Action_Behaviour {

	public Guard_Action_Behaviour (Unit_Non_Player refered_To){
		this.refered_To = refered_To;
	}

	// Update is called once per frame
	public override void update () {
	
	}

	public override void get_Player_Action (Unit unit, string action){
		if (action == "E") {
			dialogue_Action ();
		}
	}

	protected override void dialogue_Action (){
		Debug.Log ("begin dialogue");

		// Send its instance and text to the HUD
		GameObject.FindObjectOfType<HUD> ().text_State(refered_To, "coucou ! <3");
	}
}
