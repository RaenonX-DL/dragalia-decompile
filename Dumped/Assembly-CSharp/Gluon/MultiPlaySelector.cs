/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlaySelector : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public UnityEvent onAutoJoined;
		[SerializeField]
		public UnityAction<bool> onCreateRoomResult;
		[SerializeField]
		private Image[] bpBaseImages;
		[SerializeField]
		private Image[] bpOnImages;
		[SerializeField]
		private Image[] bpRedImages;
		[SerializeField]
		private Image bpBaseBarImage;
		[SerializeField]
		protected GameObject questItemIconRoot;
		[SerializeField]
		protected Image questItemIconImage;
		[SerializeField]
		protected UnityEngine.UI.Text questItemNumText;
		[SerializeField]
		protected UnityEngine.UI.Text questItemLabelText;
		[SerializeField]
		private MultiplayConsumeItem createRoomItem;
		[SerializeField]
		private MultiplayConsumeItem createPrivateRoomItem;
		[SerializeField]
		private Toggle autoCreateRoomToggle;
		[SerializeField]
		private CommonIcon currentPartyCharaIcon;
		[SerializeField]
		private float getLocationMaxWaitTime;
		[Header]
		[SerializeField]
		private GameObject[] createRoomBlackLayers;
		[SerializeField]
		private Button[] createRoomButtons;
		[SerializeField]
		private Image limitedElementalQuestCautionBg;
		[SerializeField]
		private Image limitedElementalQuestCautionIcon;
		[SerializeField]
		private LocalizeTextLayoutPadding limitedElementalQuestCautionPadding;
		[SerializeField]
		private UnityEngine.UI.Text limitedElementalQuestCautionText;
		[SerializeField]
		private Sprite limitedElementalQuestCautionBlueLabel;
		[SerializeField]
		private Sprite limitedElementalQuestCautionRedLabel;
		private MatchingAutoJoiningPopup autoJoiningPopup;
		protected EventQuestConditionPopup conditionPopup;
		private bool blockViewTimeOver;
		private bool matchingServiceActionTaken;
		private const float minBlockViewTime = 0.5f;
		private bool isAutoCreateRoom;
		private RoomEntryCondition roomCondition;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private int questId;
		private DateTime prevUpdateTime;
		private const float updateInterval = 1f;
		private const string prefabPathMatchingTypePrivatePopup = "UI/Popup/MyPage/MatchingTypePrivatePopup";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__39_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Update_b__39_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public Action failedAction;
			public int questId;
			public MultiPlaySelector __4__this;
			public Action okAction;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _CheckQuestRequirements_b__0(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_1
		{
			// Fields
			public QuestLimitedElementConfirmPopup popup;
			public __c__DisplayClass40_0 CS___8__locals1;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass40_1();
	
			// Methods
			internal void _CheckQuestRequirements_b__1();
			internal void _CheckQuestRequirements_b__2();
			internal void _CheckQuestRequirements_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public int questId;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _OnPublicButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public MatchingTypePrivatePopup popup;
			public Action __9__2;
			public Action __9__3;
			public Action __9__4;
			public Action __9__5;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _OnPrivateButtonPressed_b__0();
			internal void _OnPrivateButtonPressed_b__2();
			internal void _OnPrivateButtonPressed_b__3();
			internal void _OnPrivateButtonPressed_b__1();
			internal void _OnPrivateButtonPressed_b__4();
			internal void _OnPrivateButtonPressed_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_1
		{
			// Fields
			public TouchGuardObject touchGuard;
			public __c__DisplayClass44_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass44_1();
	
			// Methods
			internal void _OnPrivateButtonPressed_b__6();
			internal void _OnPrivateButtonPressed_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_2
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass44_2();
	
			// Methods
			internal void _OnPrivateButtonPressed_b__8();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public CommonPopup commonPopup;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _OnGuildButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetElementTextWithIconImage_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string orgStr;
			public UnityEngine.UI.Text iconInText;
			public Image icon;
			public LocalizeTextLayoutPadding elementalTextPadding;
			private string[] _strLines_5__2;
			private int _iconLine_5__3;
			private float _strHeadWidth_5__4;
			private float _strBlankWidth_5__5;
			private float _strWidth_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetElementTextWithIconImage_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public MatchingConditionPopup popup;
			public int questId;
			public MultiPlaySelector __4__this;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _OnCustomCreateButtonPressed_b__1();
			internal void _OnCustomCreateButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public QuestLimitedElementConfirmPopup popup;
			public MultiPlaySelector __4__this;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _OnAutoJoinButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public int questId;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _OnPenaltyCheckSuccess_b__0(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public int questId;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _OnSearchRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public Action onClose;
	
			// Constructors
			public __c__DisplayClass65_0();
	
			// Methods
			internal void _ErrorTypeCheck_b__0(MultiPlayError.ErrorType err);
		}
	
		// Constructors
		public MultiPlaySelector();
	
		// Methods
		public void SetContent(int questId);
		private string GetPrefsKeyRequirePower(int questId);
		private void UpdateCurrentLeader();
		private void SetConsumeValue();
		private void Update();
		private void CheckQuestRequirements(Action okAction, Action failedAction = null);
		public void OnPublicButtonPressed();
		private void CreateRoom(int questId);
		private void CreateAutoConditionRoom(int questId);
		public void OnPrivateButtonPressed();
		public void OnGuildButtonPressed();
		private TouchGuardObject CreateTouchGuardObject(string label);
		private void RemoveTouchGuardObject(TouchGuardObject touchGuard);
		private void UpdateQuestListMultiButtonsState(bool canCreateRoom, ElementalType limitedElementalType = ElementalType.NONE);
		private void SetLimitedElementalQuestCaution(ElementalType limitedElementalType);
		[IteratorStateMachine]
		private IEnumerator SetElementTextWithIconImage(string orgStr, Image icon, UnityEngine.UI.Text iconInText, LocalizeTextLayoutPadding elementalTextPadding);
		public void OnCustomCreateButtonPressed();
		public void OnAutoJoinButtonPressed();
		public void OnAutoCreateRoomTogglePressed(bool check);
		private void OnPenaltyCheck();
		private void CreateMatchingService(int questId);
		private void OnPenaltyCheckSuccess(MatchingCheckPenaltyUserResponse res);
		private void CloseEventQuestConditionPopup();
		private void OnAutoJoined();
		public void OnAutoJoinReady();
		public void OnSearchRoom();
		public void OnChangeParty();
		private bool IsFromQuestSelect();
		private bool IsFromSpecialEvent();
		private void OnAutoJoinCanceled();
		private void ErrorTypeCheck(MultiPlayError error, Action onClose = null);
		private int GetQuestId();
		private static void SetConsumeMultiStamina(int matchingEntryQuestId, bool isHost, Image baseBarImage, Image[] baseImages, Image[] onImages, Image[] redImages);
		public static void SetConsumeItem(QuestDataElement qde, bool isHost, GameObject questItemIconRoot, Image questItemIconImage, UnityEngine.UI.Text questItemNumText, bool isRatio = false);
		[CompilerGenerated]
		private void _Update_b__39_1(bool retry);
		[CompilerGenerated]
		private void _OnGuildButtonPressed_b__45_0();
		[CompilerGenerated]
		private void _OnCustomCreateButtonPressed_b__51_0();
		[CompilerGenerated]
		private void _OnAutoJoinReady_b__59_0();
		[CompilerGenerated]
		private void _OnAutoJoinReady_b__59_1();
		[CompilerGenerated]
		private void _OnChangeParty_b__61_0();
	}
}
