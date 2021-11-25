using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeMultiWeakPointUI : CharaCircleGaugeUI
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform _markUIAdjustRt;

		[SerializeField]
		protected RectTransform _wpOneDigitRt;

		[SerializeField]
		protected SpriteRenderer _wpBgImage;

		[SerializeField]
		protected SpriteRenderer _wpIconImage;

		[SerializeField]
		protected SpriteRenderer _wpMultiImage;

		[SerializeField]
		protected SpriteRenderer[] _wpCountImage;

		[SerializeField]
		[Header("resource")]
		protected Sprite[] _countSprites;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("1æ¡\u0081è¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®Xè»\u00b8èª¿æ\u0095\u00b4å\u0080¤")]
		private float _oneDigitAdjustPosX;

		[SerializeField]
		[Tooltip("é\u00a0­ä\u00b8\u008aUIè¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®Yè»\u00b8èª¿æ\u0095\u00b4å\u0080¤")]
		private float _showMarkUIAdjustPosY;

		private int _maxCount;

		public static CharaCircleGaugeMultiWeakPointUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
		{
			return null;
		}

		protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY)
		{
		}

		public override void SetCount(int count)
		{
		}

		private void SetCountSprite(ref SpriteRenderer image, int count, int targetDigit)
		{
		}

		private void SetCountSprite(ref SpriteRenderer image, int index, bool enabled)
		{
		}

		protected override void SetSortingOrder(int v, bool force = false)
		{
		}
	}
}
