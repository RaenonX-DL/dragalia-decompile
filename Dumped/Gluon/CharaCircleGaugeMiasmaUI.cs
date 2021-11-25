using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeMiasmaUI : CharaCircleGaugeUI
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform _iconAnimRootRt;

		[SerializeField]
		protected RectTransform _iconAnimRt;

		[SerializeField]
		protected SpriteRenderer _iconAnimImage;

		[SerializeField]
		protected InGameAnimUI _glowAnimUI;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«å\u0080¤ï¼\u0088x -> y -> xï¼\u0089")]
		protected Vector2 _iconAnimScale;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®ã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡å\u0080¤ï¼\u0088x -> y -> xï¼\u0089")]
		protected Vector2 _iconAnimAlpha;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®è£\u009cé\u0096\u0093æ\u0096¹æ³\u0095")]
		protected Ease _iconAnimEase;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡æ\u00af\u008eã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		protected float _animWaitTime;

		[SerializeField]
		[Tooltip("ã\u0082°ã\u0083¬ã\u0083¼ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«ã\u0081®æ¿\u0083ã\u0081\u0095")]
		protected float _grayScaleMulti;

		protected VisibleUIObject _iconAnimVisible;

		protected bool _initializedGrayScale;

		public static CharaCircleGaugeMiasmaUI Create(GameObject parent, CharacterBase owner, BossBreakUI bossBreakUI, float adjustPosY, int siblingIndex = -1)
		{
			return null;
		}

		protected override void Initialize(CharacterBase owner, BossBreakUI bossBreakUI, Type gaugeType, float adjustPosY)
		{
		}

		protected override void UpdateAnim()
		{
		}

		protected override void PlayAnim()
		{
		}

		protected override void StopAnim()
		{
		}

		protected override Color GetGaugeColor(float rate)
		{
			return default(Color);
		}

		private void InitGrayScale()
		{
		}

		protected bool CopyMaterial(ref SpriteRenderer image)
		{
			return default(bool);
		}

		public override void SetGrayScale(bool b, bool isForce = false)
		{
		}

		protected void SetGrayScaleParam(ref SpriteRenderer image, bool isGrayScale, float grayScaleMulti = 1f)
		{
		}
	}
}
