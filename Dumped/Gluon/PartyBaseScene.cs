using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyBaseScene : SceneBase
	{
		private enum EnumStete
		{
			InitWait,
			Prepare,
			GoQuest,
			Exit
		}

		public enum questTypeStatus
		{
			mainQuest,
			eventQuest,
			raidQuest,
			voidQuest,
			timeAttackQuest,
			subdueQuest
		}

		public Camera mainCamera;

		public Camera render3dCamera;

		public GameObject renderBgCanvas;

		public PartyObjectControlCanvas controlCanvas;

		public QuestCharacterCtrl[] characterCtrls;

		public Camera[] matchingCharacterCameras;

		public Transform matchingCamerasNode;

		public GameObject characterShaderSettingsObj;

		[SerializeField]
		[Header("Shader")]
		public PartyCharacterShaderSettings charaShaderSettings;

		private EnumStete matchingState;

		private Image render3dImageFrame;

		private int questId;

		public bool needInitializeCharacterFilter;

		private TouchGuardObject initTouchGuard;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public override void OnBeforeLeaving()
		{
		}

		public void FadeOutBgCanvas()
		{
		}

		private string CheckPartyModelSceneState()
		{
			return null;
		}

		private bool IsLoadBgScene(out bool isQuestSelectFlow)
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		private void OnHeaderButtonPressed(UnityAction action)
		{
		}

		public void CheckEmptyPartyLeader(UnityAction nextSceneCallBack)
		{
		}

		private void SetPartySetting(UnityAction callback)
		{
		}

		private void ShowHeader()
		{
		}

		private void Update()
		{
		}

		private bool IsTimeAttackQuest()
		{
			return default(bool);
		}

		private void StartQuest(int questID)
		{
		}

		private IEnumerator LoadSceneLoadingCheck()
		{
			return null;
		}

		private void checkMatchingErrorType()
		{
		}

		private IEnumerator checkDisconectTypeCorutine()
		{
			return null;
		}

		public static void PopupMatchingError([Optional] Action<bool> onAutoJoinFailedAction, [Optional] Action exitSceneAction)
		{
		}

		private void ExitMatchingRoomAfterCheckParty()
		{
		}

		private void ExitMatchingRoom(bool isHost, int questId, int eventId)
		{
		}

		public static void MatchingServiceDestroy()
		{
		}

		public void SetupPartyTopReuse(bool fromMatching)
		{
		}

		public void SetupCharaShader()
		{
		}

		public void OnChangedBackgroundShaderParameter()
		{
		}

		public void BackSupport([Optional] Action onAnimationDone, questTypeStatus type = questTypeStatus.mainQuest)
		{
		}
	}
}
