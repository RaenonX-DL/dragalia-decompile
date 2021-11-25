using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestPrepareScene : SceneBase, ICustomMessage
	{
		public static int selectQuestId;

		public Camera mainCamera;

		public Camera renderChangeMemberCamera;

		public QuestCharacterCtrl[] characterCtrls;

		private QuestPrepareData[] questPartyDatas;

		public QuestPrepareData subPartyMemberData;

		private QuestPrepareData[] clearPartyDatas;

		public static Action<Action> onFinishMapInstance;

		public bool isChagingSubMember;

		public QuestPrepareCanvas questPrepareCanvas;

		private PopupCanvas changeMemberPopupCanvas;

		private Vector3 localButtonBasePos;

		private AudioPlayback bgmPlayback;

		private PartyScene partyScene;

		private Button backButton;

		private EmptyQuestClearUnitData[] emptyUnitData;

		private bool isConnecting;

		public static QuestSupportListCellData supportUserData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public QuestPrepareData[] activePartyPrepareData => null;

		public bool isCurrentClearParty
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private bool IsValidPlayFlow()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		public static void PreLoad()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void ResetPartySwichClearPartyData()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator SetupRenderBg()
		{
			return null;
		}

		public void ReloadAllCharacterModels(bool isAutoSelect = false)
		{
		}

		public void ChangeMemberSelected(int index)
		{
		}

		public void ReloadClearPartyData(bool isShowEmptyPop = true)
		{
		}

		public void ReloadQuestPartyData()
		{
		}

		public void ChangeQuestPartyData(int index)
		{
		}

		private void QuestStartButtonPressed()
		{
		}

		private void PartyEditButtonPressed()
		{
		}

		private void BackButtonPressed()
		{
		}

		private void ReturnToPrevScene()
		{
		}

		private static void GoGuildScene()
		{
		}

		private bool IsMainQuest()
		{
			return default(bool);
		}

		private void BindBackButtonForQuestSupportPage()
		{
		}

		private IEnumerator DelayClearPrepareScene(float waitTime)
		{
			return null;
		}

		private void BackButtonPressedCallback()
		{
		}

		private void EventBackButtonPressedCallback()
		{
		}

		private void EventTopBackButtonPressedCallback()
		{
		}

		public void OnFooterPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		public void OnFooterLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private IEnumerator WaitExitAnim(string tabName, Footer.MenuTab tabType)
		{
			return null;
		}

		public void CreateSubPartyMemberData()
		{
		}

		public static QuestPrepareData[] CreateClearPartyData(PartySettingList[] partyData)
		{
			return null;
		}

		private void SetLayerRecursively(Transform t, int layerId)
		{
		}

		public void GetClearPartyData()
		{
		}

		public void RequestSaveClearPartyMulti(int questId)
		{
		}

		private void OnQuestGetQuestClearPartySuccess(QuestGetQuestClearPartyResponse res)
		{
		}

		private void OnWallGetWallClearPartySuccess(WallGetWallClearPartyResponse res)
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void GoToIngame()
		{
		}

		public bool HasClearPartyData()
		{
			return default(bool);
		}

		private new Coroutine StartCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		public override void OnBeforeLeaving()
		{
		}

		public override void OnPresentReceived()
		{
		}

		private void DestroyPartyBgManager(bool isImmediately = false)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		private void ShowEmptyQuestClearUnitPopup()
		{
		}

		private void Tutorial_2_1_2()
		{
		}

		private IEnumerator Tutorial_2_1_2_Coroutine()
		{
			return null;
		}

		public void GoPartyEquipScene()
		{
		}

		private void DetachFooterCallback()
		{
		}
	}
}
