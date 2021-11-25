using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CircleGauge : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Tooltip("ã\u0082µã\u0083¼ã\u0082\u00afã\u0083«ã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8é\u0087\u008f")]
		private float _circleGaugeValue;

		[SerializeField]
		[Tooltip("å\u0086\u0086å½¢ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®è¡\u00a8ç¤ºå\u0080¤")]
		private float _maxCircleGaugeValue;

		[SerializeField]
		[Tooltip("é\u0096\u008bå§\u008bè§\u0092åº¦ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		private float _startOffsetAngle;

		private SpriteRenderer _spriteRenderer;

		private void Awake()
		{
		}

		public void SetCircleValue(float v)
		{
		}
	}
}
