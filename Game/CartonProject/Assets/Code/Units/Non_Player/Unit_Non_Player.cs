using UnityEngine;
using System.Collections;

public abstract class Unit_Non_Player : Unit {
	//Attributes

	protected new Non_Player_Moves_Behaviour moves;
	protected new Non_Player_Action_Behaviour actions;
	protected new Classe classe;
	protected new Race race;

	// Use this for initialization
	protected override abstract void Start ();
	
	// Update is called once per frame
	protected override abstract void Update ();
}
