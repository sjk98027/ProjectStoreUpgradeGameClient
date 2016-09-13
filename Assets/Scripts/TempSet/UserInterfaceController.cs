﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UserInterfaceController : MonoBehaviour
{
	[SerializeField] GameObject stepUIObject;
	[SerializeField] GameObject selectStoreUI;
	[SerializeField] Step presentStep;


	void Start ()
	{
		UpdateStep(Step.First);
	}
	public enum Step : int
	{
		First = 1,
		Second = 2
	};

	public void MakeSelectUI()
	{

	}




	public void UpdateStep(Step presentStep)
	{
		Destroy( stepUIObject );

		switch ( presentStep )
		{
			case Step.First:
				stepUIObject = (GameObject) Instantiate( Resources.Load<GameObject>( "UIObject/MainUI" ), transform.position, transform.rotation );
				break;

			case Step.Second:
				stepUIObject = (GameObject)Instantiate (Resources.Load<GameObject> ("UIObject/GameViewFirstStep"), transform.position, transform.rotation);
				break;
		}
	}	
}
