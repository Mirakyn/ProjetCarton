using UnityEngine;
using System.Collections;

public class Player_Action_Behaviour : Action_Behaviour {
	private Player refered_To;
	// Use this for initialization
	public Player_Action_Behaviour (Player refered_To){
		this.refered_To = refered_To;
	}
	
	// Update is called once per frame
	public override void update () {
		if (Input.GetKey("e")){
			action_To_Unit ();
		}
	}

	private void action_To_Unit (){
		//Il doit indiquer à l'unitée la plus proche qu'une action se déroule
	}
}
