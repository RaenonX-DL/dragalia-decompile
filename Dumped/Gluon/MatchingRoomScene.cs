using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Cri;
using UniRx.Async;
using UnityEngine;

namespace Gluon
{
	public class MatchingRoomScene : SceneBase
	{
		public enum MatchingReturToType
		{
			None,
			HostQuestSelect,
			GuestJoinCoop,
			GuestQuestSelect,
			GuestGuild
		}

		public Camera mainCamera;

		[HideInInspector]
		public MatchingRoomCanvas matchingRoomCanvas;

		private readonly string mainCanvasPath;

		public static MatchingReturToType returnFlag;

		private static MatchingReturToType _savedReturnFlag;

		public static bool isExecutedBgLightProbesTetrahedralize;

		private AudioPlayback bgmPlayback;

		private GameObject mainCanvasObj;

		private PartyScene partyScene;

		private int questId;

		private Canvas canvas;

		private List<MatchingRoomCharacterModelLoadTask> loadTaskList;

		private const string defaultBgm = "BGM_OUT_0003_01";

		private readonly string stampVoice;

		private bool _isGotoPartyScene;

		private bool beforeIsShowWeaponSkin;

		public static MatchingReturToType savedReturnFlag
		{
			get
			{
				return default(MatchingReturToType);
			}
			set
			{
			}
		}

		public bool isGoToPartyScene
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private bool IsValidPlayFlow()
		{
			return default(bool);
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void Update()
		{
		}

		public static void RemoveReturnFlagForQuest()
		{
		}

		private IEnumerator SetupRenderBg()
		{
			return null;
		}

		public static UniTask LoadMatchingRoomBg(int questId, bool needLightProbeseTetrahedralize)
		{
			return default(UniTask);
		}

		public void OnInsertCharacter(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex, bool isPlayVoice, int delayIndex = 0)
		{
		}

		public void OnRemoveCharacter(int index, MatchingService.Room myRoom, int delayIndex = 0)
		{
		}

		public void OnReplaceCharacter(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex, bool isPlayVoice, int delayIndex = 0)
		{
		}

		public void OnReplacePlayerAndCharacter(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex, bool isPlayVoice, int delayIndex = 0)
		{
		}

		public void UpdateCharacterInfoOnly(int index, MatchingService.Room myRoom, int playerIndex, int memberIndex)
		{
		}

		public void LandCharacter(int positionIndex, MatchingRoomPlayerData playerData, int memberIndex, bool isPlayCharaVoice, Action<GameObject> onLoaded)
		{
		}

		public void TakeOffCharacter(int positionIndex)
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		public static void OnTryExitFromMatchingScene(Action onOK, [Optional] Action onCancel, bool isExitFromMatchingRoomButton = false)
		{
		}

		private void OnChangeWeaponSkinSetting()
		{
		}

		public static void MatchingServiceDestroy()
		{
		}

		public static void OnGuestExitToList()
		{
		}

		public void SetupTutorial()
		{
		}

		public static void ClearMatchingRoomBgTetrahedralizedFlag()
		{
		}
	}
}
