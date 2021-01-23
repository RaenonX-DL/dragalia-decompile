/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingDeniedPopup : PopupBase
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
	
		// Constructors
		public MatchingDeniedPopup();
	
		// Methods
		public void Initialize(RoomList itemData);
		public void OnClosePressed();
	}
}
