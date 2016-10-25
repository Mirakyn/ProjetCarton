using UnityEngine;
using System.Collections;

public class Guard_Action_Behaviour : Non_Player_Action_Behaviour {
	
	// Update is called once per frame
	public override void update () {
	
	}

	public override void get_Player_Action (Player player, string action){
		if (action == "E") {
			dialogue_Action (player);
		}
	}

	protected override void dialogue_Action (Player player){

	}
}
