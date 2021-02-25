/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyDetailPopup : CommonPopup
	{
		// Fields
		public GameObject editPartyNameButtonObject;
		public GameObject eventBonusButtonObject;
		public PartySelectPopupCell[] selectPopupCells;
		public Action ReladPartyNameAction;
		private int questId;
		private int partyIndex;
		private List<EventBonusPopup.EventBonusCharaInfo> eventAbilityInfo;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public EventBonusPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _OnEventBonusIconPressed_b__0();
		}
	
		// Constructors
		public PartyDetailPopup();
	
		// Methods
		public static PartyDetailPopup Create();
		public void InitPopup(int questId, int partyIndex, PartyList clearParty = null);
		public void OnEditPartyNameButtonPressed();
		public void OnEventBonusIconPressed();
		[CompilerGenerated]
		private void _OnEditPartyNameButtonPressed_b__9_0(string newName);
	}
}
