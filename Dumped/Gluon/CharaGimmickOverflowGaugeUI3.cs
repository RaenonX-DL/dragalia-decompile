using System.Collections.Generic;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickOverflowGaugeUI3 : CharaGimmickBaseGaugeUI
	{
		protected class GaugeData
		{
			public float rate;

			public int stockNum;

			public bool isPlayMaxAnim;

			public bool isImmediate;
		}

		[SerializeField]
		[Header("component")]
		protected RectTransform _rootRt;

		[SerializeField]
		protected RectTransform _gaugeBgAnimRt;

		[SerializeField]
		protected RectTransform _stockAnimRt;

		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gauge;

		[SerializeField]
		protected SpriteRenderer _stockImage;

		[SerializeField]
		protected SpriteRenderer _baseGaugeImage;

		[SerializeField]
		protected SpriteRenderer _gaugeBgAnimImage;

		[SerializeField]
		protected SpriteRenderer _stockAnimImage;

		[SerializeField]
		[Header("parameter")]
		protected Vector2 _countAnimScale;

		[SerializeField]
		protected float _countAnimTime;

		[SerializeField]
		protected Vector2 _gaugeAnimScale;

		[SerializeField]
		protected float _gaugeAnimTime;

		[SerializeField]
		protected Color _stockNumEmptyColor;

		[SerializeField]
		protected Color _stockNumColor;

		[SerializeField]
		protected Color _stockNumMaxColor;

		[SerializeField]
		protected Color _baseGaugeEmptyColor;

		[SerializeField]
		protected Color _baseGaugeColor;

		[SerializeField]
		protected Color _baseGaugeMaxColor;

		[SerializeField]
		[Header("resource")]
		protected Sprite[] _numberSpriteList;

		protected VisibleUIObject _visible;

		protected List<float> _conditionValueList;

		protected Sequence _seqGaugeAnim;

		protected Sequence _seqStockAnim;

		protected int _lastValue;

		protected float _gaugeMoveTime;

		protected List<GaugeData> _activeGaugeDataList;

		protected List<GaugeData> _standbyGaugeDataList;

		protected readonly int GaugeDataReserveNum;

		public static CharaGimmickOverflowGaugeUI3 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize(CharacterBase chara)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
		{
		}

		protected void SetGaugeDataList(int value, int maxValue, bool isImmediateGaugeAnim)
		{
		}

		protected void SetGaugeDataListAdd(int value, int maxValue, bool isImmediateGaugeAnim)
		{
		}

		protected void SetGaugeDataListSub(int value, int maxValue, bool isImmediateGaugeAnim)
		{
		}

		protected void ApplyGaugeDataList()
		{
		}

		protected virtual void OnCompleteGaugeMoveAnim(GaugeData data)
		{
		}

		protected void SetStockNum(int stockNum)
		{
		}

		protected void SetGaugeColor(int stockNum)
		{
		}

		protected GaugeData GetActiveGaugeData()
		{
			return null;
		}

		protected void AddStandbyGaugeDataList(GaugeData data)
		{
		}

		protected int GetStockMaxNum()
		{
			return default(int);
		}

		public override void SetAbilityData(ref List<AbilityDataElement> list)
		{
		}

		protected void PlayGaugeBgAnim()
		{
		}

		protected void PlayStockAnim()
		{
		}

		protected void OnUpdateAnim(RectTransform trans, Vector2 fromScale, Vector2 toScale, SpriteRenderer sprite, float fromFade, float toFade, float t)
		{
		}

		public override int GetGaugeType()
		{
			return default(int);
		}

		public override float GetGaugeMoveTime()
		{
			return default(float);
		}
	}
}
