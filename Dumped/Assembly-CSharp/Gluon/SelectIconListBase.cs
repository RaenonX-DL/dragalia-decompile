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
	public class SelectIconListBase : CommonIconListBase
	{
		// Fields
		public UnityAction tabButtonCallBack;
		public Button decideButton;
		public TabBase tab;
		public RectTransform lockButtonBase;
	
		// Constructors
		public SelectIconListBase();
	
		// Methods
		private void Start();
		public void ListTabPressedZeroToOne(int index);
		public void ListTabPressed(int tabTag);
		public void LockCharacterTab(bool interactable);
		private void CheckTutorial();
	}
}
