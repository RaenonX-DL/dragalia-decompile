using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CombatQuestMapPage : EventQuestPageBase
	{
		public class CombatLandmarkInfo
		{
			public CombatEventLocationElement locationElement;

			public CombatQuestMapObjectButton landmmark;

			public CombatLandmarkInfo(CombatEventLocationElement locationElement, CombatQuestMapObjectButton landmmark)
			{
			}
		}

		[SerializeField]
		[Header("BG")]
		private Image bgImage;

		[SerializeField]
		private Image fadeImage;

		[SerializeField]
		private Image bgPlane;

		[SerializeField]
		private AnimationUIBg bgAnimation;

		[SerializeField]
		private UIAnimationPublisher mainPublisher;

		[SerializeField]
		private AnimationUIBg bgPlaneAnimation;

		[SerializeField]
		[Header("Landmark")]
		private Transform buttonParentNode;

		[SerializeField]
		private CombatQuestMapObjectButton objectButton;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		[SerializeField]
		[Header("Nhaam")]
		private Vector2 namPos;

		[SerializeField]
		private Vector2 namScale;

		[SerializeField]
		private GameObject nhaamParent;

		private FlashPlayer twinkleFlash;

		private FlashPlayer moveFlash;

		[SerializeField]
		[Header("CompreatFlash")]
		private Transform compleatFlashParent;

		private FlashPlayer compleatFlash;

		private List<CombatLandmarkInfo> landmarkList;

		private CanvasGroup bgCanvasGroup;

		private static float locSizeScale;

		private bool isGetLocationReward;

		private int getLocationRewardId;

		private int nhaamIndex;

		private const int storyLocationId = 1;

		protected override void Awake()
		{
		}

		private void LoadObjects()
		{
		}

		private bool IsEventEnded()
		{
			return default(bool);
		}

		private static List<CombatEventLocationElement> GetLocations(int eventId)
		{
			return null;
		}

		public static QuestUtil.QuestState GetLocationState(bool isEventEnded, int locationId)
		{
			return default(QuestUtil.QuestState);
		}

		private void OnMiniCharaTouched(int masterIndex)
		{
		}

		private void TakeScreenshot()
		{
		}

		public void OnBackFromQuestList()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator EnterAnimationCoroutine()
		{
			return null;
		}

		private void CheckLocationReward()
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private IEnumerator StartLocationClearEvent(int locationId)
		{
			return null;
		}

		public static void RequestCombatEventReceiveEventLocationReward(int locationId, Action onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		private void GoQuestDetailListPage(CombatEventLocationElement loc)
		{
		}

		public void NhaamMove(int pointerIndex)
		{
		}

		public void InitializeNhaam(int sortOrder)
		{
		}

		public void PlayNhaamAnimation()
		{
		}

		public void SetSortingOrder(int sortOrder)
		{
		}

		private void PlayCompleatFlash([Optional] Action onAnimationEnded)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
