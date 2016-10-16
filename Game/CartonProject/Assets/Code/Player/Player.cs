using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private float v_speed = 5;
	private float h_speed = 5;

	private float v_Movement = 0;
	private float h_Movement = 0;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () { 
		//Movement update
		move();

		// Sprite transition update
		move_animation ();
	}

	/**
	 * Used to check the movement of the player by pressing the axis input given by unity
	 */
	private void move (){
		v_Movement = Input.GetAxis("Vertical") * v_speed;
		h_Movement = Input.GetAxis("Horizontal") * h_speed;

		v_Movement *= Time.deltaTime;
		h_Movement *= Time.deltaTime;

		transform.Translate (h_Movement, v_Movement, 0);
	}

	/**
	 * Used to change the sprite animation depending of the movement of the unit
	 */
	private void move_animation (){
		if (v_Movement > 0) {
			animator.SetBool ("Top", true);
			animator.SetBool ("Bottom", false);

		} else if (v_Movement < 0) {
			animator.SetBool ("Bottom", true);
			animator.SetBool ("Top", false);

		} else if (h_Movement > 0) {
			animator.SetBool ("Right", true);
			animator.SetBool ("Left", false);

		} else if (h_Movement < 0) {
			animator.SetBool ("Left", true);
			animator.SetBool ("Right", false);

		}
		if (v_Movement == 0f){
			animator.SetBool ("Top", false);
			animator.SetBool ("Bottom", false);
		}

		if (h_Movement == 0f) {
			animator.SetBool ("Left", false);
			animator.SetBool ("Right", false);
		}
	}
}
