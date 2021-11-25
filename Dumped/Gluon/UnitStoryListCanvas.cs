using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitStoryListCanvas : AnimationUICanvas
	{
		public UnitStoryListScene scene;

		[SerializeField]
		public Canvas uiCanvas;

		[SerializeField]
		private RectTransform frameRect;

		[SerializeField]
		private TabBase typeTab;

		[SerializeField]
		public Badge[] unreadBadge;

		[SerializeField]
		private TabBase readTab;

		[SerializeField]
		public UnitStoryListController baseListController;

		[SerializeField]
		private GameObject sortButtonRoot;

		[SerializeField]
		public GameObject castleObjRoot;

		[SerializeField]
		public Image triggerItemImage;

		[SerializeField]
		public Text triggerItemNumText;

		[SerializeField]
		public Image sampleBannerImage;

		private const float reduceFrameAreaHeightForSample = 180f;

		protected override void Awake()
		{
		}

		public void InitCanvas()
		{
		}

		public void OnSortButtonPressed()
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}
	}
}
