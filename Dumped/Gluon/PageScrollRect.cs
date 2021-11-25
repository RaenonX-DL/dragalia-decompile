using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Gluon
{
	public class PageScrollRect : DragEventScrollRect
	{
		public int startPage;

		public int maxPage;

		public float smooth;

		public float pageSwipeOffset;

		public bool loopPage;

		public UnityAction<int> changePage;

		private Vector2 targetPosition;

		private float hPerPage;

		public int nowIndex;

		private int hIndex;

		private int horizontalPages;

		private Vector2 oldNormalizedPosition;

		private Vector2 moveStartPosition;

		private bool isMoveLeft;

		private const float boundMarginX = 0.02f;

		private new void Awake()
		{
		}

		private new void Start()
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		private void MovePageAnimation(float posx)
		{
		}

		private void MoveAnimationComplete()
		{
		}

		private void UpdateIndex()
		{
		}

		private Vector2 GetSnapPosition()
		{
			return default(Vector2);
		}

		public void NextPageChange(int nextPage)
		{
		}

		private void SetMovePageAnimation()
		{
		}

		public void SetMaxPage(int max)
		{
		}
	}
}
