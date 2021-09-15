/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		[SerializeField]
		private UnityEngine.UI.Text partyChangeButtonText;
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
		private LocalizeTextLayoutPadding limitedQuestPadding;
		[SerializeField]
		private UnityEngine.UI.Text limitedElementalQuestCautionText;
		[SerializeField]
		private Sprite limitedElementalQuestCautionBlueLabel;
		[SerializeField]
		private Sprite limitedElementalQuestCautionRedLabel;
		[SerializeField]
		private Image limitedWeaponTypeCautionBaseIcon;
		[SerializeField]
		private GameObject limitedWeaponTypeCautionIconPanel;
		[SerializeField]
		private UnityEngine.UI.Text limitedWeaponTypeCautionText;
		[SerializeField]
		private UnityEngine.UI.Text limitedQuestForCalcText;
		private MatchingAutoJoiningPopup autoJoiningPopup;
		protected EventQuestConditionPopup conditionPopup;
		private bool blockViewTimeOver;
		private bool matchingServiceActionTaken;
		private const float minBlockViewTime = 0.5f;
		private bool isAutoCreateRoom;
		private RoomEntryCondition roomCondition;
		private QuestAutoTransitionUtil.MultiJoinBaseLocation multiJoinBaseLocation;
		private int questId;
		private Action<bool> goSwitchPrepareSceneAction;
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
			public static Action __9__45_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Update_b__45_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public Action failedAction;
			public int questId;
			public MultiPlaySelector __4__this;
			public Action okAction;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _CheckQuestRequirements_b__0();
			internal void _CheckQuestRequirements_b__1(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_1
		{
			// Fields
			public QuestLimitedConfirmPopup popup;
			public __c__DisplayClass46_0 CS___8__locals1;
			public UnityAction __9__4;
	
			// Constructors
			public __c__DisplayClass46_1();
	
			// Methods
			internal void _CheckQuestRequirements_b__2();
			internal void _CheckQuestRequirements_b__3();
			internal void _CheckQuestRequirements_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public MatchingTypePrivatePopup popup;
			public Action __9__2;
			public Action __9__3;
			public Action __9__4;
			public Action __9__5;
			public Action __9__6;
			public Action __9__7;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _OnPrivateButtonPressed_b__0();
			internal void _OnPrivateButtonPressed_b__2();
			internal void _OnPrivateButtonPressed_b__3();
			internal void _OnPrivateButtonPressed_b__4();
			internal void _OnPrivateButtonPressed_b__1();
			internal void _OnPrivateButtonPressed_b__5();
			internal void _OnPrivateButtonPressed_b__6();
			internal void _OnPrivateButtonPressed_b__7();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public MatchingTypePrivatePopup popup;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _CreateLocationPrivateRoom_b__0();
			internal void _CreateLocationPrivateRoom_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_1
		{
			// Fields
			public TouchGuardObject touchGuard;
			public __c__DisplayClass51_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass51_1();
	
			// Methods
			internal void _CreateLocationPrivateRoom_b__2();
			internal void _CreateLocationPrivateRoom_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_2
		{
			// Fields
			public CommonPopup errorPopup;
	
			// Constructors
			public __c__DisplayClass51_2();
	
			// Methods
			internal void _CreateLocationPrivateRoom_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public MatchingTypePrivatePopup popup;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _CreatePrivateRoom_b__0();
			internal void _CreatePrivateRoom_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public CommonPopup commonPopup;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal void _OnGuildButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public MatchingConditionPopup popup;
			public MultiPlaySelector __4__this;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _CreateCustomRoom_b__1();
			internal void _CreateCustomRoom_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public QuestLimitedConfirmPopup popup;
			public MultiPlaySelector __4__this;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _AutoJoinRoom_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public MultiPlaySelector __4__this;
			public int questId;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _OnPenaltyCheckSuccess_b__0(bool isRecoveredStamina);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public PartySwitchPopup popup;
			public MultiPlaySelector __4__this;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _OnChangeParty_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public Action onClose;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _ErrorTypeCheck_b__0(MultiPlayError.ErrorType err);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action cancelAction;
	
			// Constructors
			public __c__DisplayClass83_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_1
		{
			// Fields
			public PartySwitchPopup switchPopup;
			public __c__DisplayClass83_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass83_1();
	
			// Methods
			internal void _ShowPartySwitchIfNeeded_b__0();
		}
	
		// Constructors
		public MultiPlaySelector();
	
		// Methods
		public void SetContent(int questId, Action<bool> goSwitchPrepareSceneAction = null);
		private string GetPrefsKeyRequirePower(int questId);
		private void UpdateCurrentLeader();
		private void SetConsumeValue();
		private void Update();
		private void CheckQuestRequirements(Action okAction, Action failedAction = null);
		public void OnPublicButtonPressed();
		private void CreateRoom();
		private void CreateAutoConditionRoom(int questId);
		public void OnPrivateButtonPressed();
		private void CreateLocationPrivateRoom(MatchingTypePrivatePopup popup);
		private void CreatePrivateRoom(MatchingTypePrivatePopup popup);
		public void OnGuildButtonPressed();
		private void CreateGuildRoom();
		private TouchGuardObject CreateTouchGuardObject(string label);
		private void RemoveTouchGuardObject(TouchGuardObject touchGuard);
		private void InitializeLimitedQuestCautionSetting(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList);
		private void UpdateQuestListMultiButtonsState(bool limitedElementalEnough, bool limitedWeaponTypeEnough, ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList);
		private void SetLimitedElementalQuestCaution(ElementalType limitedElementalType);
		private bool SetLimitedWeaponTypeQuestCaution(List<WeaponType> limitedWeaponTypeList);
		public void OnCustomCreateButtonPressed();
		private void CreateCustomRoom();
		public void OnAutoJoinButtonPressed();
		private void AutoJoinRoom();
		public void OnAutoCreateRoomTogglePressed(bool check);
		private void OnPenaltyCheck();
		private void CreateMatchingService(int questId);
		private void OnPenaltyCheckSuccess(MatchingCheckPenaltyUserResponse res);
		private void CloseEventQuestConditionPopup();
		private void OnAutoJoined();
		public void OnAutoJoinReady();
		public void OnSearchRoom();
		public void ShowSearchRoomPopup(Transform parentTransform);
		public void OnChangeParty();
		private void OnUpdateParty();
		private bool IsFromQuestSelect();
		private bool IsFromSpecialEvent();
		private void OnAutoJoinCanceled();
		private void ErrorTypeCheck(MultiPlayError error, Action onClose = null);
		private int GetQuestId();
		private static void SetConsumeMultiStamina(int matchingEntryQuestId, bool isHost, Image baseBarImage, Image[] baseImages, Image[] onImages, Image[] redImages);
		public static void SetConsumeItem(QuestDataElement qde, bool isHost, GameObject questItemIconRoot, Image questItemIconImage, UnityEngine.UI.Text questItemNumText, bool isRatio = false);
		public static PartySwitchPopup ShowPartySwitchIfNeeded(PartySwitchLocation location, GameObject parentObject, int questId, Action matchingAction, Action goPrepareAction, Action cancelAction = null);
		public static int GetMatchingPartyIndex(int questId);
		public static int[] CreateUsePartySlots(int questId);
		public static void CheckLimitedElementAndWeapon(int questId, out ElementalType limitedElementalType, out bool isLimitedElementalQuestEnough, out List<WeaponType> limitedWeaponTypeList, out bool isLimitedWeaponTypeQuestEnough);
		private void GoSwitchPrepareScene();
		[CompilerGenerated]
		private void _Update_b__45_1(bool retry);
		[CompilerGenerated]
		private void _OnPublicButtonPressed_b__47_0();
		[CompilerGenerated]
		private void _CreateGuildRoom_b__54_0();
		[CompilerGenerated]
		private void _CreateCustomRoom_b__62_0();
		[CompilerGenerated]
		private void _OnAutoJoinReady_b__71_0();
		[CompilerGenerated]
		private void _OnAutoJoinReady_b__71_1();
		[CompilerGenerated]
		private void _ShowSearchRoomPopup_b__73_0(int a, QuestAutoTransitionUtil.GuestEnterRoomFromType b);
	}
}
