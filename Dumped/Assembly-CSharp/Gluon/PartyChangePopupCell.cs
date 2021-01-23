/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyChangePopupCell : MonoBehaviour
	{
		// Fields
		public Image elementIcon;
		public UnityEngine.UI.Text partyName;
		public UnityEngine.UI.Text partyPower;
		public CommonUnitIcon[] commonUnitIcons;
		public GameObject[] emptyIconObjects;
		private int partyIndex;
		private Action<int> changeCallBack;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public PartyDetailPopup popup;
			public PartyChangePopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0();
			internal void _OnDetailButtonPressed_b__1();
			internal void _OnDetailButtonPressed_b__2();
		}
	
		// Constructors
		public PartyChangePopupCell();
	
		// Methods
		public void UpdateCell(int partyIndex, Action<int> changeCallBack);
		public void OnDetailButtonPressed();
		public void OnChangeButtonPressed();
		public void OnCharaIconPressed(int tag);
	}
}
