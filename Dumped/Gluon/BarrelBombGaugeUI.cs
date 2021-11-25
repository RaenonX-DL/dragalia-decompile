using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class BarrelBombGaugeUI : FastUpdateMonoBehaviour
	{
		private enum BlinkState
		{
			Idle,
			In,
			Out
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _bgRt;

		[SerializeField]
		private RectTransform _blinkRt;

		[SerializeField]
		private SpriteRenderer _bgImage;

		[SerializeField]
		private SpriteRenderer _gaugeImage;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private SpriteRenderer _blinkImage;

		[SerializeField]
		private CircleGauge _gaugeCtrl;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("æ\u0098\u008eæ»\u0085ã\u0081®é\u0096\u008bå§\u008bæ\u0099\u0082é\u0096\u0093ï¼\u0088æ®\u008bã\u0082\u008aæ\u0099\u0082é\u0096\u0093ï¼\u0089")]
		private float _blinkStartRemainTime;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085ã\u0081®ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡å\u0080¤ï¼\u0088x -> y -> xï¼\u0089")]
		private Vector2 _blinkAlpha;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085æ\u0099\u0082é\u0096\u0093")]
		private float _blinkDurationTime;

		[SerializeField]
		[Tooltip("3Dç©ºé\u0096\u0093ä\u00b8\u008aã\u0081®Yè»\u00b8åº§æ\u00a8\u0099èª¿æ\u0095\u00b4å\u0080¤")]
		private float _adjust3DPosY;

		[SerializeField]
		[Tooltip("2Dç©ºé\u0096\u0093ä\u00b8\u008aã\u0081®Yè»\u00b8åº§æ\u00a8\u0099èª¿æ\u0095\u00b4å\u0080¤")]
		private float _adjust2DPosY;

		private VisibleUIObject _rootVisible;

		private VisibleUIObject _blinkVisible;

		private GameObject _owner;

		private Vector3 _settingPosition;

		private Vector3 _settingLocalScale;

		private Color _gaugeColor;

		private bool _show;

		private int _curSortingOrder;

		private int _defSortingOrder;

		private float _blinkTime;

		private BlinkState _blinkState;

		private static int _createCount;

		private int DefaultSortingOrder;

		private static readonly Color[] GAUGE_COLOR;

		private static readonly float[] GAUGE_COLOR_THRESHOLD;

		private static readonly int GAUGE_COLOR_NUM;

		public static BarrelBombGaugeUI Create(GameObject parent, GameObject owner, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(GameObject owner)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void Update()
		{
		}

		private void UpdatePosition()
		{
		}

		public void SetPosition(Vector3 setPosition, Vector3 scale)
		{
		}

		private Vector2 GetScreenPosition(Vector3 position, Vector3 localscale)
		{
			return default(Vector2);
		}

		public void SetAdjust2DPosY(float adjust)
		{
		}

		public void SetAdjust3DPosY(float adjust)
		{
		}

		private void UpdateBlink()
		{
		}

		public void SetGaugeTimer(float remainTime, float durationTime)
		{
		}

		private void SetGaugeRate(float rate)
		{
		}

		private Color GetGaugeColor(float rate)
		{
			return default(Color);
		}

		private void SetBlinkAlpha(float a)
		{
		}

		private void EnableBlink()
		{
		}

		private void DisableBlink()
		{
		}

		private bool IsShow()
		{
			return default(bool);
		}

		private void InitSortingOrder()
		{
		}

		public void SetSortingOrder(int sortingOrder)
		{
		}

		public void ResetSortingOrder()
		{
		}

		private void SetSortingOrder(int v, bool force = false)
		{
		}
	}
}
