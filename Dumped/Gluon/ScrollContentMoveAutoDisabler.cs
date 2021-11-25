using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ScrollContentMoveAutoDisabler : MonoBehaviour
	{
		public enum WorldCornerIndex
		{
			BottomLeft,
			TopLeft,
			TopRight,
			BottomRight
		}

		[SerializeField]
		public bool isContentSizeStable;

		private ScrollRect scrollRect;

		private Vector3[] contentWorldCorners;

		private Vector3[] viewportWorldCorners;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void AdjustByContentAndViewport()
		{
		}
	}
}
