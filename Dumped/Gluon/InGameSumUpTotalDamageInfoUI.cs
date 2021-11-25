using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class InGameSumUpTotalDamageInfoUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0082¦ã\u0083³ã\u0082¿ã\u0083¼å\u0088¶å¾¡")]
		private InGameCounterUI _counterCtrl;

		private float _headerMargin;

		public static InGameSumUpTotalDamageInfoUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetCount(long count)
		{
		}

		public void Visible(bool b)
		{
		}
	}
}
