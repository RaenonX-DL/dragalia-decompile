using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameLossGaugeUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private GameObject rootObj;

		[SerializeField]
		private Image bgImage;

		[SerializeField]
		private RectTransform gainMask;

		[SerializeField]
		private Image gainBar;

		[SerializeField]
		private RectTransform baseMask;

		[SerializeField]
		private Image baseBar;

		[SerializeField]
		private Image blinkImage;

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
		private Color baseColor;

		[SerializeField]
		private Color maxColor;

		[SerializeField]
		private Color dyingColor;

		[SerializeField]
		private Color incColor;

		[SerializeField]
		private Color blinkColor0;

		[SerializeField]
		private Color blinkColor1;

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

		private RectTransform gainBarRT;

		private RectTransform baseBarRT;

		private GameObject gainGameObj;

		private GameObject baseGameObj;

		private GameObject blinkGameObj;

		private Vector2 gaugeSize;

		private float gaugeWidth;

		private float gainRemainTime;

		private float lastValue;

		private Color srcColor;

		private Color blinkColor;

		private Tweener blinkTweener;

		private VisibleUIObject rootVisible;

		private VisibleUIObject gainVisible;

		private VisibleUIObject baseVisible;

		private VisibleUIObject blinkVisible;

		public void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetValue(float value, bool immediate)
		{
		}

		public float GetValue()
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

		private void SetBaseMaskSize(float value)
		{
		}

		private float GetBaseMaskValue()
		{
			return default(float);
		}

		private bool WaitTime(ref float t, ref float remainTime)
		{
			return default(bool);
		}

		private void SetBaseColor(Color color)
		{
		}

		private void SetBGSprite(int idx)
		{
		}

		private void SetBaseSprite(int idx)
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
	}
}
