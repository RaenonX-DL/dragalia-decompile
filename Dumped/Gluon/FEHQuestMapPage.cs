using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FEHQuestMapPage : EventQuestPageBase
	{
		[SerializeField]
		[Header("BG")]
		public Image bgImage;

		public Image fadeImage;

		[SerializeField]
		private Image bgPlane;

		[SerializeField]
		[Header("Animation")]
		public AnimationUIBg bgAnimation;

		public UIAnimationPublisher mainPublisher;

		[SerializeField]
		private AnimationUIBg bgPlaneAnimation;

		[SerializeField]
		[Header("MiniChara")]
		public Transform miniCharaParentNode;

		public FEHQuestMapMiniCharaButton miniCharaButtonTemplate;

		public FlashPlayerManager flashPlayerManager;

		private FlashPlayer[] miniCharaFlashPlayers;

		private Transform[] miniCharaMoveTransforms;

		private List<int> miniCharaDisplayOrder;

		private CanvasGroup bgCanvasGroup;

		private static float locSizeScale;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private QuestUtil.QuestState GetLocationState(bool isEventEnded, int locationId)
		{
			return default(QuestUtil.QuestState);
		}

		private void LoadMiniChara()
		{
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

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private void GoQuestDetailListPage(Clb01EventLocationElement loc)
		{
		}

		public static void CheckSecondHarlPopup(bool isOpenPopup)
		{
		}
	}
}
