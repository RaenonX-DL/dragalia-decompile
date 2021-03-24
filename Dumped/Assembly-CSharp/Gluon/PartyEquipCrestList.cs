/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipCrestList : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private PartyEquipCrest[] crestList;
		[SerializeField]
		private GameObject emptyMessageObject;
		[SerializeField]
		private VerticalLayoutGroup layout;
		[SerializeField]
		private RectTransform frameRectTransform;
		private WeaponBodyList userWeaponData;
		private WeaponBodyElement weaponData;
		public Action onCrestChangeCallback;
	
		// Nested types
		private enum SlotState
		{
			None = 0,
			Enable = 1,
			Locked = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<int, int> __9__8_0;
			public static Func<PartyEquipCrest, bool> __9__8_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Reload_b__8_0(int crestId);
			internal bool _Reload_b__8_1(PartyEquipCrest e);
		}
	
		// Constructors
		public PartyEquipCrestList();
	
		// Methods
		public void Reload(bool isSupportFriend = false);
		private SlotState GetSlotState(int index);
		private int GetSlotType(int index);
	}
}
