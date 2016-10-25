using UnityEngine;
using System.Collections;

public class Guard_Moves_Behaviour : Non_Player_Moves_Behaviour {

	public Guard_Moves_Behaviour (Guard refered_To){
		this.refered_To = refered_To;
	}
	
	// Update is called once per frame
	public override void update (int speed) {
	
	}
}
