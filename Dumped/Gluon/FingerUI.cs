using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class FingerUI : MonoBehaviour
	{
		[SerializeField]
		private RectTransform pointNode;

		[SerializeField]
		private RectTransform rotNode;

		[SerializeField]
		[Header("pointing")]
		private int repeatCount;

		[SerializeField]
		private float moveTime;

		[SerializeField]
		private float waitTime;

		[SerializeField]
		private float distance;

		[SerializeField]
		[Header("swipe")]
		private float swipeRotate;

		[SerializeField]
		private float swipeDistance;

		[SerializeField]
		private float swipeTime1;

		[SerializeField]
		private float swipeWaitTime;

		[SerializeField]
		private float swipeTime2;

		private int count;

		private Tweener tweenerPoint;

		private Tweener tweenerSwipe;

		private RectTransform rectTransform;

		public static FingerUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public void Open(Vector2 pos, float rotateZ = 0f, bool isLeft = false)
		{
		}

		public void OpenSwipe(Vector2 pos)
		{
		}

		public void Close()
		{
		}

		public void Release()
		{
		}

		private void DoAnimation(bool isLeft)
		{
		}

		public void SetPosition(Vector2 pos)
		{
		}

		private void OnUpdatePoint(float value)
		{
		}

		private void OnCompletePoint0()
		{
		}

		private void OnCompletePoint1()
		{
		}

		private void OnUpdateSwipe(float value)
		{
		}

		private void OnCompleteSwipe0()
		{
		}

		private void OnCompleteSwipe1()
		{
		}
	}
}
