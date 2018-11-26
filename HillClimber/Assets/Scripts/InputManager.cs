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
}
