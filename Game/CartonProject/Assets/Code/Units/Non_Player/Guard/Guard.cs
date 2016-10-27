using UnityEngine;
using System.Collections;

public class Guard : Unit_Non_Player {

	// Use this for initialization
	protected override void Start () {
		animator = GetComponent<Animator>();
		moves = new Guard_Moves_Behaviour (this);
		actions = new Guard_Action_Behaviour (this);
	}

	//
	protected override void Start (string name_Unit, int max_Life, int strength, int defense, int speed){
		animator = GetComponent<Animator>();
		moves = new Guard_Moves_Behaviour (this);
		actions = new Guard_Action_Behaviour (this);
	}

	//
	protected override void Start (string name_Unit, int life, int max_Life, int strength, int defense, int speed){
		animator = GetComponent<Animator>();
		moves = new Guard_Moves_Behaviour (this);
		actions = new Guard_Action_Behaviour (this);
	}
	
	// Update is called once per frame
	protected override void Update () {
		// procedure de test pour les dialogues
		if (Input.GetKey("e")){
			actions.get_Player_Action (null, "E");
		}
	}
}
