using UnityEngine;

namespace Gluon
{
	public class CharaCircleGaugeScapegoatUI : CharaCircleGaugeUI
	{
		[SerializeField]
		[Header("component")]
		protected RectTransform _oneDigitRt;

		[SerializeField]
		protected SpriteRenderer[] _countImage;

		[SerializeField]
		[Header("resource")]
		protected Sprite[] _countSprites;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("1æ¡\u0081è¡\u00a8ç¤ºæ\u0099\u0082ã\u0081®Xè»\u00b8èª¿æ\u0095\u00b4å\u0080¤")]
		private float _oneDigitAdjustPosX;

		public static CharaCircleGaugeScapegoatUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1)
		{
			return null;
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
	}
}
