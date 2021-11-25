using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class InGameGaugeUISpriteRenderer : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class GaugeColorData
		{
			public Color baseColor;

			public Color maxColor;

			public Color dyingColor;

			public Color incColor;

			public Color decColor;

			public Color blinkColor0;

			public Color blinkColor1;
		}

		private enum BaseGaugeSpriteType
		{
			Normal,
			Dying,
			Max
		}

		private enum BgSpriteType
		{
			Normal,
			Dying
		}

		[SerializeField]
		[Header("component")]
		private GameObject rootObj;

		[SerializeField]
		private SpriteRenderer bgImage;

		[SerializeField]
		private Transform lossMask;

		[SerializeField]
		private SpriteRenderer lossBar;

		[SerializeField]
		private Transform gainMask;

		[SerializeField]
		private SpriteRenderer gainBar;

		[SerializeField]
		private Transform baseMask;

		[SerializeField]
		private SpriteRenderer baseBar;

		[SerializeField]
		private SpriteRenderer blinkImage;

		[SerializeField]
		[Header("resource")]
		[Tooltip("0:é\u0080\u009aå\u00b8\u00b8æ\u0099\u0082ã\u0081®ä\u00b8\u008bå\u009c°, 1:ç\u0080\u0095æ­»æ\u0099\u0082ã\u0081®ä\u00b8\u008bå\u009c°")]
		private Sprite[] bgSprite;

		[SerializeField]
		private bool useGaugeSprite;

		[SerializeField]
		[Tooltip("0:é\u0080\u009aå\u00b8\u00b8, 1:ç\u0080\u0095æ­», 2:Max")]
		private Sprite[] gaugeSprite;

		[SerializeField]
		[Header("color")]
		[Tooltip("ã\u0083\u0099ã\u0083¼ã\u0082¹ã\u0082«ã\u0083©ã\u0083¼")]
		private Color baseColor;

		[SerializeField]
		[Tooltip("æ\u009c\u0080å¤§æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color maxColor;

		[SerializeField]
		[Tooltip("ç\u0080\u0095æ­»æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color dyingColor;

		[SerializeField]
		[Tooltip("å¢\u0097å\u008a\u00a0æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color incColor;

		[SerializeField]
		[Tooltip("æ\u00b8\u009bå°\u0091æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color decColor;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color blinkColor0;

		[SerializeField]
		[Tooltip("æ\u0098\u008eæ»\u0085æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼ï¼\u0092")]
		private Color blinkColor1;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082«ã\u0083©ã\u0083¼ã\u0083ªã\u0082¹ã\u0083\u0088ï¼\u0088ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082«ã\u0083©ã\u0083¼ã\u0082\u0092å¤\u0089æ\u009b\u00b4ã\u0081\u0097ã\u0081ªã\u0081\u0084å\u00a0\u00b4å\u0090\u0088è\u00a8­å®\u009aä\u00b8\u008dè¦\u0081ï¼\u0089")]
		private GaugeColorData[] gaugeColorList;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¹ã\u0083\u0097ã\u0083©ã\u0082¤ã\u0083\u0088 mask or slice ?")]
		private bool isMaskedSprite;

		[SerializeField]
		private float initialValue;

		[SerializeField]
		private float dyingRate;

		[SerializeField]
		[Tooltip("æº\u009cã\u0082\u0081æ\u0099\u0082é\u0096\u0093(s)")]
		private float waitTime;

		[SerializeField]
		[Tooltip("å·®å\u0088\u0086ç§»å\u008b\u0095æ\u0099\u0082é\u0096\u0093(s/å¹\u0085)")]
		private float diffMoveTime;

		[SerializeField]
		[Tooltip("ç\u0082¹æ»\u0085æ\u0099\u0082é\u0096\u0093(s)")]
		private float blinkTime;

		[SerializeField]
		[Tooltip("9ã\u0082¹ã\u0083©ã\u0082¤ã\u0082¹æ\u009c\u0089å\u008a¹ã\u0083\u0095ã\u0083©ã\u0082°")]
		private bool isNineSlice;

		[SerializeField]
		[Tooltip("9ã\u0082¹ã\u0083©ã\u0082¤ã\u0082¹ã\u0081§ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082µã\u0082¤ã\u0082ºã\u0081\u008cï¼\u0091ç\u009b®ç\u009b\u009bã\u0082\u008aã\u0081«æº\u0080ã\u0081\u009fã\u0081\u0097ã\u0081¦ã\u0081\u0084ã\u0081ªã\u0081\u0084å\u00a0\u00b4å\u0090\u0088ã\u0081®ä\u00b8\u00b8ã\u0082\u0081è¾¼ã\u0081¿ã\u0083\u0095ã\u0083©ã\u0082°\nï¼\u0088HPã\u0081\u008cï¼\u0091ã\u0081®é\u009a\u009bã\u0081«ï¼\u0091ç\u009b®ç\u009b\u009bã\u0082\u008aã\u0081\u00a8ã\u0081\u0097ã\u0081¦æ\u0089±ã\u0081\u0084ã\u0081\u009fã\u0081\u0084ã\u0081ªã\u0081©ï¼\u0089")]
		private bool isNineSliceGraduationRound;

		[SerializeField]
		[Tooltip("9ã\u0082¹ã\u0083©ã\u0082¤ã\u0082¹ã\u0081®ç\u009b®ç\u009b\u009bã\u0082\u008aã\u0081®ã\u0082µã\u0082¤ã\u0082º")]
		private float nineSliceGraduationSize;

		private Transform lossBarRT;

		private Transform gainBarRT;

		private Transform baseBarRT;

		private GameObject blinkGameObj;

		private Vector3 gaugeSize;

		private float gaugeWidth;

		private float lossRemainTime;

		private float gainRemainTime;

		private float lastRate;

		private int maxNineSliceGraduationNum;

		private int gaugeColorIndex;

		private Color gaugeBaseColor;

		private Color gaugeMaxColor;

		private Color gaugeDyingColor;

		private Color gaugeIncColor;

		private Color gaugeDecColor;

		private Color gaugeBlinkColor0;

		private Color gaugeBlinkColor1;

		private Color changeColor;

		private Color baseOrgColor;

		private Color blinkOrgColor;

		private Tweener blinkTweener;

		private VisibleUIObject rootVisible;

		private bool bgImageEnabled;

		private bool lossBarEnabled;

		private bool gainBarEnabled;

		private bool baseBarEnabled;

		private bool blinkImageEnabled;

		private bool isChangeColor;

		private bool isDying;

		public Action<float> onComplete
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float BlinkValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float WaitTime => default(float);

		public float DiffMoveTime => default(float);

		public float BlinkTime => default(float);

		public void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetGaugeColor(int gaugeColorIndex, bool immediate = false)
		{
		}

		public void SetValue(float value, bool immediate, bool ignoreValueApproximately = false)
		{
		}

		public float GetLastRate()
		{
			return default(float);
		}

		public float GetCurrentRate()
		{
			return default(float);
		}

		public bool IsDying()
		{
			return default(bool);
		}

		public bool IsMax()
		{
			return default(bool);
		}

		public void Visible(bool value)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public bool IsChanging()
		{
			return default(bool);
		}

		public void SetBlink(bool on, int index = 0)
		{
		}

		public bool IsBlink()
		{
			return default(bool);
		}

		private void SetBarSize(float value)
		{
		}

		private void SetLossMaskSize(float value)
		{
		}

		private void SetGainMaskSize(float value)
		{
		}

		private void SetBaseMaskSize(float value)
		{
		}

		private float GetBaseMaskRate()
		{
			return default(float);
		}

		public float GetGainMaskRate()
		{
			return default(float);
		}

		public float GetLossMaskRate()
		{
			return default(float);
		}

		public float GetBaseMaskValue()
		{
			return default(float);
		}

		public float GetGainMaskValue()
		{
			return default(float);
		}

		private bool UpdateWaitTime(ref float t, ref float remainTime)
		{
			return default(bool);
		}

		private void SetBaseColor(Color color)
		{
		}

		private void SetBGSprite(BgSpriteType type)
		{
		}

		private void SetBaseGaugeSprite(BaseGaugeSpriteType type)
		{
		}

		private void StartBlink()
		{
		}

		private void StopBlink()
		{
		}

		private void OnUpdateBlink(float v)
		{
		}

		private void SetVisibleSpriteRenderer()
		{
		}

		public void SetDiffMoveTime(float time)
		{
		}

		public void SetChangeColor(Color color)
		{
		}

		public void SetChangeColorFlag(bool change, bool force = false)
		{
		}

		private void ApplyChangeColor(bool change)
		{
		}

		private Color GetGaugeBaseColor()
		{
			return default(Color);
		}

		public void SetGaugeBaseColor(Color color, bool force = false)
		{
		}

		private Color GetGaugeMaxColor()
		{
			return default(Color);
		}

		public void SetGaugeMaxColor(Color color, bool force = false)
		{
		}

		private Color GetGaugeDyingColor()
		{
			return default(Color);
		}

		private Color GetGaugeIncColor()
		{
			return default(Color);
		}

		private Color GetGaugeDecColor()
		{
			return default(Color);
		}

		private Color GetGaugeBlinkColor0()
		{
			return default(Color);
		}

		private Color GetGaugeBlinkColor1()
		{
			return default(Color);
		}

		public float GetGaugeMoveTime()
		{
			return default(float);
		}

		public float GetGaugeWaitTime()
		{
			return default(float);
		}

		public float GetGaugeDiffMoveTime()
		{
			return default(float);
		}
	}
}
