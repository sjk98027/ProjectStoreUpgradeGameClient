﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class PlayerDisplayItem : MonoBehaviour {

	[SerializeField] protected Text haveItemNameCount;
	[SerializeField] protected Image itemImage;
	[SerializeField] protected Image selectedImage;
	[SerializeField] protected bool isSelected;
	[SerializeField] protected Item thisItem;

	public void LinkComponentElement()
	{
		haveItemNameCount = GetComponentInChildren<Text> ();
		itemImage = transform.Find ("Image").GetComponent<Image> ();
		selectedImage = transform.Find ("NameCountBackImage").GetComponent<Image> ();
		isSelected = false;
	}


	//!! to be continue;
	public void UpdateComponentElement(Item playItem){
		string a = (playItem.Name + " / " + playItem.Count).ToString ();

		//haveItemNameCount = (playItem.Name+" / " + playItem.Count).ToString();
	}

	//Sell Button -> SellViewSet-> sellButtonSelected
	public void ClickPlayerDisPlayItemSelect()
	{
		SellViewSet sellMain = gameObject.GetComponentInParent<SellViewSet>();
		sellMain.SellSelectedItem(thisItem);
	}




}