using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeDrasticForceUI : CharaCircleGaugeUI
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform _countAdjustRt;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform _countRt_01;

		[SerializeField]
		[Tooltip("è\u00a8\u0098å\u008f·ç\u0094»å\u0083\u008f")]
		protected SpriteRenderer _countMultiImage;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088ç\u0094»å\u0083\u008fã\u0083ªã\u0082¹ã\u0083\u0088")]
		protected SpriteRenderer[] _countImageArray;

		[SerializeField]
		[Header("resource")]
		protected Sprite[] _countSprites;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("1æ¡\u0081è¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®ã\u0082«ã\u0082¦ã\u0083³ã\u0083\u0088èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0ã\u0081®Xè»\u00b8èª¿æ\u0095\u00b4å\u0080¤")]
		private float _oneDigitCountAdjustPosX;

		[SerializeField]
		[Tooltip("1æ¡\u0081è¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®ï¼\u0091æ¡\u0081ç\u009b®ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0ã\u0081®Xè»\u00b8èª¿æ\u0095\u00b4å\u0080¤")]
		private float _oneDigitCountPosX_01;

		private int _maxCount;

		public static CharaCircleGaugeDrasticForceUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
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

		public override void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false)
		{
		}

		protected override void SetSortingOrder(int v, bool force = false)
		{
		}
	}
}
