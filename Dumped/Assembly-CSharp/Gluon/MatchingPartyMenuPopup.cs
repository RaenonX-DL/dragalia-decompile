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
	public class MatchingPartyMenuPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEvent autoPartyButtonPressed;
		[Header]
		[SerializeField]
		public UnityEvent charaPartyButtonPressed;
		[Header]
		[SerializeField]
		public UnityEvent bgButtonPressed;
	
		// Constructors
		public MatchingPartyMenuPopup();
	
		// Methods
		public void OnAutoPartyButtonPressed();
		public void OnCharaPartyButtonPressed();
		public void OnBgButtonPressed();
	}
}
