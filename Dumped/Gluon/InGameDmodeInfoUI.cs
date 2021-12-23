using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameDmodeInfoUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform rootRt;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082³ã\u0082¢ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text scoreText;

		[SerializeField]
		[Tooltip("ã\u0083\u0095ã\u0083­ã\u0082¢ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text floorText;

		public static InGameDmodeInfoUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetScore(int val)
		{
		}

		public void SetFloor(int val, bool isForce = false)
		{
		}

		public void Visible(bool b)
		{
		}
	}
}
