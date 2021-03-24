/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartySwitchQuestStartPopup : CommonPopup
	{
		// Fields
		private int questId;
		[SerializeField]
		private GameObject baseCell;
		[SerializeField]
		private Transform cellParent;
		private PartySettingList[] questClearParty;
		private PartySwitchPopupCell[] cellList;
		private const int partySwitchPartyCount = 2;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public PartySwitchQuestStartPopup popup;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<Action> __9__10_0;
			public static Action __9__10_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GoToIngame_b__10_0(Action onAnimationDone);
			internal void _GoToIngame_b__10_1();
		}
	
		// Constructors
		public PartySwitchQuestStartPopup();
	
		// Methods
		public static PartySwitchQuestStartPopup Create(int questId);
		private void SetupCells();
		private void CheckMask();
		public void OnPressStartQuest();
		private void GoToIngame();
		private void OnJoinConditionsFailed(StringBuilder failedDescription);
		private void OnTemporaryCharaInParty();
		public override void OnCloseButtonPressed();
	}
}
