﻿using UnityEngine;
using System.Collections;

public abstract class Unit : MonoBehaviour {
	//Attributes
	protected Animator animator;

	protected BoxCollider2D body_Form;
	protected CircleCollider2D speaking_Raduis;
	protected Moves_Behaviour moves;
	protected Action_Behaviour actions;
	protected Classe classe;
	protected Race race;

	[SerializeField]
	protected string name_Unit;
	[SerializeField]
	protected int life;
	[SerializeField]
	protected int max_Life;
	[SerializeField]
	protected int strength;
	[SerializeField]
	protected int defense;
	[SerializeField]
	protected int speed;

	//
	protected abstract void Start ();

	//
	protected abstract void Start (string name_Unit, int max_Life, int strength, int defense, int speed);

	//
	protected abstract void Start (string name_Unit, int life, int max_Life, int strength, int defense, int speed);
	
	// Update is called once per frame
	protected abstract void Update ();


	//Getter & Setter
	public Animator get_Animator (){
		return animator;
	}

	public int get_Speed (){
		return speed;
	}

	public string get_Name (){
		return this.name_Unit;
	}
}
