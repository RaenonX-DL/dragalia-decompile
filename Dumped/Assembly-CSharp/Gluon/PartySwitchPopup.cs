/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartySwitchPopup : CommonPopup
	{
		// Fields
		private Action gotoPrepareSceneAction;
		private Action copyPartyAction;
		private int questId;
		[SerializeField]
		private GameObject baseCell;
		[SerializeField]
		private Transform cellParent;
		private PartySettingList[] questClearParty;
		private PartySwitchPopupCell[] cellList;
		private const int partySwitchPartyCount = 2;
		private QuestPartySwitchModel partySwitchModel;
		private GameObject parentObject;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public PartySwitchPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<Action> __9__19_0;
			public static Action __9__19_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GoToIngame_b__19_0(Action onAnimationDone);
			internal void _GoToIngame_b__19_1();
		}
	
		// Constructors
		public PartySwitchPopup();
	
		// Methods
		public static PartySwitchPopup Create(GameObject parentObject, int questId, Action gotoPrepareSceneAction, Action copyPartyAction, bool isRequestClearParty);
		private void SetupCells(bool isRequestClearParty);
		private void CheckMask();
		private void OnQuestGetQuestClearPartySuccess(QuestGetQuestClearPartyResponse res);
		private void FromationButtonAction(int partyIndex, int cellIndex, bool isClearParty);
		private void ChangeButtonAction(int partyIndex, int cellIndex);
		private void CopyButtonAction();
		public void OnPressStartQuest();
		public override void OnOkButtonPressed();
		private void GoToIngame();
		private void OnJoinConditionsFailed(StringBuilder failedDescription);
		private void OnTemporaryCharaInParty();
	}
}
