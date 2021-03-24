/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingDeniedPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private CommonIcon currentPartyCharaIcon;
		[SerializeField]
		private UnityEngine.UI.Text requirePower;
		[SerializeField]
		private GameObject[] requireElements;
		[SerializeField]
		private GameObject requireWeaponRoot;
		[SerializeField]
		private GameObject[] requireWeapons;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public MatchingDeniedPopup popup;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _Create_b__0();
			internal void _Create_b__1();
			internal void _Create_b__2();
		}
	
		// Constructors
		public MatchingDeniedPopup();
	
		// Methods
		public static MatchingDeniedPopup Create(GameObject parentObject, RoomList itemData);
		private void Initialize(RoomList itemData);
	}
}
