/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SellIconListBase : CommonIconListBase
	{
		// Fields
		public UnityAction tabButtonCallBack;
		public UnityAction sellModeButtonCallBack;
		public UnityAction listChangeButtonCallBack;
		public Button sellModeButton;
		public TabBase tab;
		public RectTransform lockButtonBase;
		public GameObject searchSpaceObject;
		[SerializeField]
		private GameObject listButtonObj;
	
		// Constructors
		public SellIconListBase();
	
		// Methods
		private void Start();
		private void SetModeText();
		public void ListTabPressedZeroToOne(int index);
		public void ListTabPressed(int tabTag);
		public void LockCharacterTab(bool interactable);
		public void SellChangeButtonPressed();
		private void CheckTutorial();
		public void OnListChangeButtonPressed();
	}
}
