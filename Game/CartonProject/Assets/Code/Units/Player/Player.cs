using UnityEngine;
using System.Collections;

public class Player : Unit {
	//Attributes
	public Player (){}
	//
	protected override void Start(){
		animator = GetComponent<Animator>();
		body_Form = GetComponent<BoxCollider2D> ();
		speaking_Raduis = GetComponent<CircleCollider2D> ();

		moves = new Player_Moves_Behaviour (this);
		actions = new Player_Action_Behaviour (this);
	}

	//
	protected override void Start (string name_Unit, int max_Life, int strength, int defense, int speed){
		this.name_Unit = name_Unit;
		this.life = max_Life;
		this.max_Life = max_Life;
		this.strength = strength;
		this.defense = defense;
		this.speed = speed;

		animator = GetComponent<Animator>();
		moves = new Player_Moves_Behaviour (this);
	}

	//
	protected override void Start (string name_Unit, int life, int max_Life, int strength, int defense, int speed){
		this.name_Unit = name_Unit;
		this.life = life;
		this.max_Life = max_Life;
		this.strength = strength;
		this.defense = defense;
		this.speed = speed;

		animator = GetComponent<Animator>();
		moves = new Player_Moves_Behaviour (this);
	}

	// Update is called once per frame
	protected override void Update () { 
		//Movement update
		moves.update (this.speed);
		actions.update ();
	}
}
