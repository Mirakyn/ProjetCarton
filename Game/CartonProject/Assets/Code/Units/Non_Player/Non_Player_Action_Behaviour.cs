using UnityEngine;
using System.Collections;

public abstract class Non_Player_Action_Behaviour : Action_Behaviour {
	protected Unit_Non_Player refered_To;

	// Update is called once per frame
	public abstract override void update ();

	public abstract void get_Player_Action (Unit unit, string action);

	protected abstract void dialogue_Action ();
}
