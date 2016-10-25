using UnityEngine;
using System.Collections;

public class Player_Moves_Behaviour : Moves_Behaviour {

	public Player_Moves_Behaviour (Player refered_To){
		this.refered_To = refered_To;
	}

	/**
	 * Override update to enable the utilization by players or other unit classes
	 */
	public override void update (int speed){
		Vector2 moves = move_object (speed);
		move_animation (moves);
	}

	/**
	 * Used to move the player with inputs
	 * @param speed, speed to use
	 */
	private Vector2 move_object (int speed){
		float v_Movement = Input.GetAxis("Vertical") * speed;
		float h_Movement = Input.GetAxis("Horizontal") * speed;

		// Calcul of the deepth 
		float d_Movement = Input.GetAxis("Vertical") / 20;

		v_Movement *= Time.deltaTime;
		h_Movement *= Time.deltaTime;

		refered_To.transform.Translate (h_Movement, v_Movement, d_Movement);
		return new Vector2 (v_Movement, h_Movement);
	}

	/**
	 * Used to change the sprite animation depending of the movement of the unit
	 */
	private void move_animation (Vector2 movements){
		//get moves
		float v_Movement = movements.x;
		float h_Movement = movements.y;

		//Get the animator to modify
		Animator animator = refered_To.getAnimator ();

		//Make the animator modification(s)
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
