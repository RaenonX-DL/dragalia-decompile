using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class InGameButtonGaugeUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private GameObject rootObj;

		[SerializeField]
		private RectTransform gainMask;

		[SerializeField]
		private SpriteRenderer gainBar;

		[SerializeField]
		private RectTransform baseMask;

		[SerializeField]
		private SpriteRenderer baseBar;

		[SerializeField]
		private SpriteRenderer blinkImage;

		[SerializeField]
		private Sprite[] baseSprites;

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

		private GameObject gainGameObj;

		private GameObject baseGameObj;

		private GameObject blinkGameObj;

		private Vector2 gainMaskScale;

		private Vector2 baseMaskScale;

		private float baseMaskWorldSizeX;

		private float gainRemainTime;

		private float lastValue;

		private Color srcColor;

		private Color blinkColor;

		private Tweener blinkTweener;

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

		public float GetBaseMaskValue()
		{
			return default(float);
		}

		public Vector3 GetEffectPosition(Vector3 effectBaseBoss)
		{
			return default(Vector3);
		}

		private bool WaitTime(ref float t, ref float remainTime)
		{
			return default(bool);
		}

		private void SetBaseColor(Color color)
		{
		}

		public void SetFillColor(Color color)
		{
		}

		public void SetFillBaseBar(Sprite[] sprites)
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
