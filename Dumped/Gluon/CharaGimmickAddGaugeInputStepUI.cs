using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickAddGaugeInputStepUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _gaugeRt;

		[SerializeField]
		private RectTransform _separateRt;

		[SerializeField]
		private SpriteRenderer _gaugeImage;

		[SerializeField]
		[Header("resource")]
		private Sprite[] _stepSprite;

		private VisibleUIObject _visibleRoot;

		private VisibleUIObject _visibleGauge;

		private VisibleUIObject _visibleSeparate;

		private float _gaugeWidth;

		private float _separatePosX;

		private bool _initialized;

		public RectTransform SeparateRt => null;

		public void Initialize(Transform parent, int index)
		{
		}

		public void SetParam(float diffInputRate, bool showSeparate)
		{
		}

		public void ShowGauge()
		{
		}

		public void HideGauge()
		{
		}

		public void Hide()
		{
		}
	}
}
