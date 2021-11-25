using System;
using Gluon.Master;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillCompleteCanvas : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private GameObject spineRoot;

		[SerializeField]
		private Text messageTitle;

		[SerializeField]
		private Text messageBody;

		[SerializeField]
		private CanvasGroup messageBoardCanvasGroup;

		[SerializeField]
		private RectTransform messageBoardRect;

		[SerializeField]
		private float enterFadeFrame;

		[SerializeField]
		private float boardMoveFrame;

		private SkeletonGraphic nhaamCompleteSkeletonGraphic;

		private Action onCompleteDirectionFinish;

		private const string nhaamCompleteAnimationPath = "Prefabs/OutGame/MissionDrill/pf_TeacherNhaamComplete";

		private const string seComplete = "SE_OUT_COMMONUSE_0004";

		private Vector3 messageBoardRectInitPosition;

		private float messageBoardMoveHeight;

		public void Initialize(Action onPlayComplete)
		{
		}

		public void PlayCompleteDirection(DrillTalkElement talk)
		{
		}

		public void PlayExitAnimation()
		{
		}

		private void PlayNhaamCompleteAnimation(string skinName, string motionName, string idleName, string voice)
		{
		}

		private void PlayNhaamExitAnimation(Action onComplete)
		{
		}

		public void OnPressed()
		{
		}
	}
}
