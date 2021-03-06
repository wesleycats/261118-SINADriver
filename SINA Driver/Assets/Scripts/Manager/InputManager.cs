using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	[SerializeField]
	private float axisThreshhold = 0.2f;
	//This variable is for managing the fidelity on controllers

	/* 
     * functions that return values for the wasd/arrow buttons
     */
	public bool Up()
	{
		return Input.GetAxis(Strings.Movement.VERTICAL) > axisThreshhold;
	}
	public bool Down()
	{
		return Input.GetAxis(Strings.Movement.VERTICAL) < -axisThreshhold;
	}
	public bool Left()
	{
		return Input.GetAxis(Strings.Movement.HORIZONTAL) < -axisThreshhold;
	}
	public bool Right()
	{
		return Input.GetAxis(Strings.Movement.HORIZONTAL) > axisThreshhold;
	}

	public bool Enter(){
		if (Input.GetKey (KeyCode.Return) || Input.GetKey (KeyCode.KeypadEnter)) {
			return true;
		} else {
			return false;
		}
	}

	public bool Backspace(){
		if (Input.GetKey (KeyCode.Backspace)) {
			return true;
		} else {
			return false;
		}
	}

	public bool Space(){
		if (Input.GetKey (KeyCode.Space)) {
			return true;
		} else {
			return false;
		}
	}

	public bool E(){
		if (Input.GetKey (KeyCode.E)) {
			return true;
		} else {
			return false;
		}
	}

	public bool F(){
		if (Input.GetKey (KeyCode.F)) {
			return true;
		} else {
			return false;
		}
	}

	public bool Escape(){
		if(Input.GetKey(KeyCode.Escape)){
			return true;
		} else {
			return false;
		}
	}

}