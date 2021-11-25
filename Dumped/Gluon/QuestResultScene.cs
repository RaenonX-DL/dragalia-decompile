using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultScene : SceneBase
	{
		[SerializeField]
		[Header("HttpGreenLight")]
		private GameObject httpGreenLight;

		[SerializeField]
		[Header("Nodes")]
		private Transform topNode;

		[SerializeField]
		private Transform rankupNode;

		[SerializeField]
		private Image questBg;

		[SerializeField]
		private Image uiBackGround;

		[SerializeField]
		public Camera flashCamera;

		[SerializeField]
		public Camera mainCamera;

		[SerializeField]
		private float levelUpPageDelayTime;

		[SerializeField]
		public Transform tapToNextTrans;

		[SerializeField]
		public Transform headerTrans;

		[SerializeField]
		public Transform wallFlashTrans;

		[SerializeField]
		public Transform battleRoyalFlashTrans;

		public Transform pagesTransform;

		public Canvas questResultSceneCanvas;

		public Transform bgCameraTransform;

		private Vector2 tapToNextAnchorMin;

		private Vector2 tapToNextAnchorMax;

		private Vector2 tapToNextAnchoredPosition;

		private int tapToNextSortOrder;

		private QuestResultTopPage topPage;

		private QuestResultNewEnrollmentPopup newEnrollmentPage;

		private QuestResultPlayerLevelUpPage levelUpPage;

		private FlashPlayer tapToNextFlash;

		private bool isLimitedEventQuest;

		private bool isMainStoryQuest;

		private BaseCanvasContents eventSkippedBaseCanvasContents;

		private QuestWallResultTopPage wallTopPage;

		private bool isQuestWall;

		private EventKindType eventKindType;

		private int eventViewType;

		public FlashPlayerManager flashPlayerManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestResultPlayerLevelUpPage LevelUpPage => null;

		public QuestResultTopPage TopPage => null;

		public bool isQuestRepeatedWithMoreThanOnce
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReadyRequestHttp()
		{
		}

		private void OnEnterScene()
		{
		}

		private void TerminateRepeat()
		{
		}

		private void RequestForUseItem(List<AtgenUseItemList> itemList, Action onDone, Action onFailed)
		{
		}

		private IEnumerator OnEnterSceneCoroutine()
		{
			return null;
		}

		public void TapToNextIn()
		{
		}

		public void TapToNextOut()
		{
		}

		public void LoadTopView()
		{
		}

		public void SetupTopView()
		{
		}

		public void LoadPlayerLevelupView(int toLevel)
		{
		}

		public void LoadNewEnrollmentPage(int id, QuestResultNewEnrollmentPopup.NewEnrollmentType type, Action onFinish)
		{
		}

		public void OnPlayerLavelUp(int toLevel)
		{
		}

		private IEnumerator LevelUp(int toLevel)
		{
			return null;
		}

		public void LoadNextScene()
		{
		}

		private string GetNextSceneName()
		{
			return null;
		}

		public void CameraDepth(int depth)
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnBeforeLeaving()
		{
		}
	}
}
