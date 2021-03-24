/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartySwitchPopup : CommonPopup
	{
		// Fields
		private Action gotoPrepareSceneAction;
		private Action okButtonAction;
		private int questId;
		[SerializeField]
		private GameObject baseCell;
		[SerializeField]
		private Transform cellParent;
		[SerializeField]
		private RectTransform scrollViewRect;
		[SerializeField]
		private UnityEngine.UI.Text multiText;
		private PartySettingList[] questClearParty;
		private PartySwitchPopupCell[] cellList;
		private const int partySwitchPartyCount = 2;
		private QuestPartySwitchModel partySwitchModel;
		private GameObject parentObject;
		private PartySwitchLocation partySwitchLocation;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public PartySwitchPopup popup;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public PartySwitchPopup popup;
			public Action onOkPressed;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _CreateForChangeParty_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public PartySwitchPopup popup;
			public Action matchingAction;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _CreateForMulti_b__0();
			internal void _CreateForMulti_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<Action> __9__27_0;
			public static Action __9__27_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GoToIngame_b__27_0(Action onAnimationDone);
			internal void _GoToIngame_b__27_1();
		}
	
		// Constructors
		public PartySwitchPopup();
	
		// Methods
		public static PartySwitchPopup Create(PartySwitchLocation location, GameObject parentObject, int questId, Action gotoPrepareSceneAction, bool isRequestClearParty);
		public static PartySwitchPopup CreateForChangeParty(PartySwitchLocation location, GameObject parentObject, int questId, Action gotoPrepareSceneAction, bool isRequestClearParty, Action onOkPressed = null);
		public static PartySwitchPopup CreateForMulti(PartySwitchLocation location, GameObject parentObject, int questId, Action gotoPrepareSceneAction, Action matchingAction, bool isRequestClearParty);
		private void SetupCells(bool isRequestClearParty);
		private void CheckMask();
		private void UpdatePartyName();
		private void OnQuestGetQuestClearPartySuccess(QuestGetQuestClearPartyResponse res);
		private void FromationButtonAction(int partyIndex, int cellIndex, bool isClearParty);
		private void ChangeButtonAction(int partyIndex, int cellIndex);
		private void CopyButtonAction(int cellIndex);
		public void OnPressStartQuest();
		private void StartSoloQuest();
		private void CheckStartQuest(Action onCheckSuccess);
		public override void OnOkButtonPressed();
		private void GoToIngame();
		private void OnJoinConditionsFailed(StringBuilder failedDescription);
		private void OnTemporaryCharaInParty();
		private void ShowMultiText(bool bShow);
		private void SetOKButtonText(PartySwitchLocation location);
		[CompilerGenerated]
		private void _StartSoloQuest_b__24_0();
	}
}
