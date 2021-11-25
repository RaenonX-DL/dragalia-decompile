using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeUI : FastUpdateMonoBehaviour
	{
		public enum Type
		{
			None,
			Electrified,
			Virus,
			MultiWeakPoint,
			Miasma,
			Scapegoat,
			AbilityReborn,
			DrasticForce
		}

		protected enum BlinkState
		{
			Idle,
			In,
			Out,
			Wait
		}

		[Serializable]
		public class GaugeColorData
		{
			[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082«ã\u0083©ã\u0083¼")]
			public Color color;

			[Tooltip("é\u0096¾å\u0080¤")]
			public float threshold;

			public GaugeColorData()
			{
			}

			public GaugeColorData(Color color, float threshold)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		protected RectTransform _rootRt;

		[SerializeField]
		protected RectTransform _adjustRt;

		[SerializeField]
		protected RectTransform _blinkRt;

		[SerializeField]
		protected SpriteRenderer _bgImage;

		[SerializeField]
		protected SpriteRenderer _gaugeImage;

		[SerializeField]
		protected SpriteRenderer _iconImage;

		[SerializeField]
		protected SpriteRenderer _blinkImage;

		[SerializeField]
		protected CircleGauge _gaugeCtrl;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8è\u0089²æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088")]
		protected GaugeColorData[] _gaugeColorDataList;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085ã\u0081®é\u0096\u008bå§\u008bæ\u0099\u0082é\u0096\u0093ï¼\u0088æ®\u008bã\u0082\u008aæ\u0099\u0082é\u0096\u0093ï¼\u0089")]
		protected float _blinkStartRemainTime;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085ã\u0081®ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡å\u0080¤ï¼\u0088x -> y -> xï¼\u0089")]
		protected Vector2 _blinkAlpha;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085æ\u0099\u0082é\u0096\u0093")]
		protected float _blinkDurationTime;

		protected VisibleUIObject _rootVisible;

		protected VisibleUIObject _blinkVisible;

		protected CharacterBase _owner;

		protected CharacterMarkUI _markUI;

		protected BossBreakUI _bossBreakUI;

		protected Color _gaugeColor;

		protected float _lastGaugeRate;

		protected int _lastSortingOrder;

		protected int _defSortingOrder;

		protected float _blinkTime;

		protected BlinkState _blinkState;

		protected bool _lastGrayScale;

		protected const int PlayerSortingOrder = -1;

		protected const int DefaultSortingOrder = -2;

		public bool IsVisible
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Type GaugeType
		{
			[CompilerGenerated]
			get
			{
				return default(Type);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected virtual void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY)
		{
		}

		protected virtual void Initialize(CharacterBase owner, BossBreakUI bossBreakUI, Type gaugeType, float adjustPosY)
		{
		}

		protected void Initialize(CharacterBase owner, Type gaugeType, float adjustPosY)
		{
		}

		public virtual bool Show()
		{
			return default(bool);
		}

		public virtual bool Hide()
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		protected virtual void UpdateAnim()
		{
		}

		public virtual void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false)
		{
		}

		public virtual void SetGaugeValue(float value, float maxValue, bool isPlayAnim = true, bool isForce = false)
		{
		}

		protected virtual void SetGaugeRate(float rate, bool isForce = false)
		{
		}

		public virtual void SetCount(int count)
		{
		}

		protected virtual Color GetGaugeColor(float rate)
		{
			return default(Color);
		}

		protected void SetGaugeColorAlpha(ref SpriteRenderer image, float a)
		{
		}

		protected void SetAlpha(ref SpriteRenderer image, float a)
		{
		}

		protected void SetScale(ref RectTransform trans, float s)
		{
		}

		protected virtual void PlayAnim()
		{
		}

		protected virtual void StopAnim()
		{
		}

		protected bool IsShow()
		{
			return default(bool);
		}

		protected void InitSortingOrder()
		{
		}

		protected void UpdateSortingOrder()
		{
		}

		protected virtual void SetSortingOrder(int v, bool force = false)
		{
		}

		public void SetAdjustPos(Vector3 pos)
		{
		}

		public void SetAdjustScale(float scale)
		{
		}

		protected bool IsParentVisible()
		{
			return default(bool);
		}

		protected CharacterBase GetOwner()
		{
			return null;
		}

		public virtual void SetGrayScale(bool b, bool isForce = false)
		{
		}
	}
}
