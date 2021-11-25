using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonUpdatedCanvas : AnimationUICanvas
	{
		public SummonUpdatedScene scene;

		public Button skipButton;

		public GameObject movieParent;

		public RectTransform movieViewRect;

		public Tweener showWindowTween;

		public RectTransform periodWindowRootRect;

		[SerializeField]
		private GameObject tapToNextItem;

		[SerializeField]
		private CanvasGroup periodWindowGroup;

		[SerializeField]
		private Text periodMainCaptionText;

		[SerializeField]
		private Text periodInfoText;

		[SerializeField]
		private GameObject[] periodLayoutObj;

		[SerializeField]
		private Text[] periodCaptionText;

		[SerializeField]
		private Text[] periodText;

		[SerializeField]
		private Vector2 periodWindowInitPos;

		private Vector2 periodWindowTargetPos;

		private readonly Vector2 swingingBackValue;

		private Sequence tapTween;

		private void Start()
		{
		}

		public void OnSkipButtonPressed()
		{
		}

		public void EnableTapToNext(bool enable)
		{
		}

		public void SetPeriodWindowText(PlatinumLegendOpeningSetting setting)
		{
		}

		public void ShowPeriodWindow()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
