using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MultiPlaySelector : MonoBehaviour
	{
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
		protected Text questItemNumText;

		[SerializeField]
		protected Text questItemLabelText;

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
		private Text partyChangeButtonText;

		[SerializeField]
		[Header("Limited Quest")]
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
		private Text limitedElementalQuestCautionText;

		[SerializeField]
		private Sprite limitedElementalQuestCautionBlueLabel;

		[SerializeField]
		private Sprite limitedElementalQuestCautionRedLabel;

		[SerializeField]
		private Image limitedWeaponTypeCautionBaseIcon;

		[SerializeField]
		private GameObject limitedWeaponTypeCautionIconPanel;

		[SerializeField]
		private Text limitedWeaponTypeCautionText;

		[SerializeField]
		private Text limitedQuestForCalcText;

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

		public void SetContent(int questId, [Optional] Action<bool> goSwitchPrepareSceneAction)
		{
		}

		private string GetPrefsKeyRequirePower(int questId)
		{
			return null;
		}

		private void UpdateCurrentLeader()
		{
		}

		private void SetConsumeValue()
		{
		}

		private void Update()
		{
		}

		private void CheckQuestRequirements(Action okAction, [Optional] Action failedAction)
		{
		}

		public void OnPublicButtonPressed()
		{
		}

		private void CreateRoom()
		{
		}

		private void CreateAutoConditionRoom(int questId)
		{
		}

		public void OnPrivateButtonPressed()
		{
		}

		private void CreateLocationPrivateRoom(MatchingTypePrivatePopup popup)
		{
		}

		private void CreatePrivateRoom(MatchingTypePrivatePopup popup)
		{
		}

		public void OnGuildButtonPressed()
		{
		}

		private void CreateGuildRoom()
		{
		}

		private TouchGuardObject CreateTouchGuardObject(string label)
		{
			return null;
		}

		private void RemoveTouchGuardObject(TouchGuardObject touchGuard)
		{
		}

		private void InitializeLimitedQuestCautionSetting(ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList)
		{
		}

		private void UpdateQuestListMultiButtonsState(bool limitedElementalEnough, bool limitedWeaponTypeEnough, ElementalType limitedElementalType, List<WeaponType> limitedWeaponTypeList)
		{
		}

		private void SetLimitedElementalQuestCaution(ElementalType limitedElementalType)
		{
		}

		private bool SetLimitedWeaponTypeQuestCaution(List<WeaponType> limitedWeaponTypeList)
		{
			return default(bool);
		}

		public void OnCustomCreateButtonPressed()
		{
		}

		private void CreateCustomRoom()
		{
		}

		public void OnAutoJoinButtonPressed()
		{
		}

		private void AutoJoinRoom()
		{
		}

		public void OnAutoCreateRoomTogglePressed(bool check)
		{
		}

		private void OnPenaltyCheck()
		{
		}

		private void CreateMatchingService(int questId)
		{
		}

		private void OnPenaltyCheckSuccess(MatchingCheckPenaltyUserResponse res)
		{
		}

		private void CloseEventQuestConditionPopup()
		{
		}

		private void OnAutoJoined()
		{
		}

		public void OnAutoJoinReady()
		{
		}

		public void OnSearchRoom()
		{
		}

		public void ShowSearchRoomPopup(Transform parentTransform)
		{
		}

		public void OnChangeParty()
		{
		}

		private void OnUpdateParty()
		{
		}

		private bool IsFromQuestSelect()
		{
			return default(bool);
		}

		private bool IsFromSpecialEvent()
		{
			return default(bool);
		}

		private void OnAutoJoinCanceled()
		{
		}

		private void ErrorTypeCheck(MultiPlayError error, [Optional] Action onClose)
		{
		}

		private int GetQuestId()
		{
			return default(int);
		}

		private static void SetConsumeMultiStamina(int matchingEntryQuestId, bool isHost, Image baseBarImage, Image[] baseImages, Image[] onImages, Image[] redImages)
		{
		}

		public static void SetConsumeItem(QuestDataElement qde, bool isHost, GameObject questItemIconRoot, Image questItemIconImage, Text questItemNumText, bool isRatio = false)
		{
		}

		public static PartySwitchPopup ShowPartySwitchIfNeeded(PartySwitchLocation location, GameObject parentObject, int questId, Action matchingAction, Action goPrepareAction, [Optional] Action cancelAction)
		{
			return null;
		}

		public static int GetMatchingPartyIndex(int questId)
		{
			return default(int);
		}

		public static int[] CreateUsePartySlots(int questId)
		{
			return null;
		}

		public static void CheckLimitedElementAndWeapon(int questId, out ElementalType limitedElementalType, out bool isLimitedElementalQuestEnough, out List<WeaponType> limitedWeaponTypeList, out bool isLimitedWeaponTypeQuestEnough)
		{
		}

		private void GoSwitchPrepareScene()
		{
		}
	}
}
