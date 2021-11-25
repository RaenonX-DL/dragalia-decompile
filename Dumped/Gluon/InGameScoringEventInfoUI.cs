using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameScoringEventInfoUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _adjustRt;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083«æ\u0095°ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text _killText;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0082¤ã\u0083³ã\u0083\u0088ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text _pointText;

		private VisibleUIObject _rootVisible;

		private int _lastKill;

		private int _lastPoint;

		private bool _isLeft;

		private const int MaxValue = 999999999;

		public static InGameScoringEventInfoUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		public void SetLayout(bool isLeft)
		{
		}

		public void SetKillNum(int value, bool isForce = false)
		{
		}

		public void SetPoint(int value, bool isForce = false)
		{
		}
	}
}
