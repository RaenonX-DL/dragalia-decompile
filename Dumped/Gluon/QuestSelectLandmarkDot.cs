using System.Collections.Generic;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectLandmarkDot : QuestSelectRoutePoint
	{
		public enum landmarkStateType
		{
			Start,
			Appear,
			Appeared
		}

		public int startAnimationFrame;

		private FlashPlayer flashLandmark;

		public landmarkStateType landmarkState;

		private QuestSelectScene.Difficulty difficulty;

		private float landmarkMove;

		private FlPlane _landmarkIcon;

		private GameObject uiObj;

		private bool _isPrepareFlyAnimation;

		private const int flashSortOrder = 4;

		private const float landmarkmoveDuration = 1f;

		private const float startFlame = 1f;

		private const float appearFlame = 1.33f;

		private const float shadowAnimScale = 1.364f;

		private const int ribbonOpenFrame = 16;

		private const string ribbonMotionObjectName = "MOT_ribbon_container";

		private const string appearedLabelName = "appeared";

		private const string appearedEndLabelName = "appear_end";

		private const string motBaseIcon = "MOT_base_icon";

		private const string motBaseIconEnd = "end";

		private const string ribbonClose = "out";

		private Sequence landmarkAnimationTween;

		public FlPlane landmarkIcon
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public float moveDuration => default(float);

		public bool isPrepareFlyAnimation => default(bool);

		private void OnDestroy()
		{
		}

		public void Initialize(QuestSelectScene scene, FlashPlayerManager flashLandmarkManager, QuestMainLocationElement qmle, GameObject ui, int flashSortOrder)
		{
		}

		public void SetAutoDestroyFlagOff()
		{
		}

		public override void StartActivation()
		{
		}

		public override void ActivateImmediately()
		{
		}

		public int GetPlainCount()
		{
			return default(int);
		}

		public void LandmarkAnimation()
		{
		}

		private FlPlane GetPlane(string str)
		{
			return null;
		}

		private List<FlPlane> GetPlaneList(string str)
		{
			return null;
		}

		public void RibbonPlayClose()
		{
		}

		public void RibbonPlayMomentOpen()
		{
		}

		public void ShadowEnable(bool enable)
		{
		}
	}
}
