using UnityEngine;
using System.Collections;

public abstract class Non_Player_Action_Behaviour : Action_Behaviour {

	// Update is called once per frame
	public abstract override void update ();

	public abstract void get_Player_Action (Player player, string action);

	protected abstract void dialogue_Action (Player player);
}
