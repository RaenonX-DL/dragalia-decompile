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
	public class PartyCrestSetDetailPopup : CommonPopup
	{
		// Fields
		public PartyEquipCrest[] crestCells;
		public GameObject errorTextObject;
		public GameObject unionBonusButtonObject;
		public GameObject eventBonusButtonObject;
		private List<EventBonusPopup.EventBonusCharaInfo> eventAbilityInfo;
		private List<UnionBonusPopup.UnionBonusInfo> unionBonusCharaInfoList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public EventBonusPopup popup;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _OnEventButtonPressed_b__0();
		}
	
		// Constructors
		public PartyCrestSetDetailPopup();
	
		// Methods
		public static PartyCrestSetDetailPopup Create();
		public void InitPopup(int setIndex, bool canSelectCrestSet = true, bool isEquipData = false);
		public void OnEventButtonPressed();
		public void OnUnionButtonPressed();
		private PartyList GetActivePartyCopyData();
	}
}
