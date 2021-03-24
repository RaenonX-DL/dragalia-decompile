/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PopupListButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public EventInt iconPressed;
		[HideInInspector]
		private int iconIndex;
		private GiftType giftType;
		private GrowthScene.OnGrowCharaListPress callback;
	
		// Nested types
		[Serializable]
		public class EventInt : UnityEvent<int>
		{
			// Constructors
			public EventInt();
		}
	
		// Constructors
		public PopupListButton();
	
		// Methods
		public void SetIconState(int inventoryId, GiftType type, GrowthScene.OnGrowCharaListPress setCallback);
		public void OnIconPressed();
	}
}
