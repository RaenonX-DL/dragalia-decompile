using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class GrowthSecondManaCircleDraggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public GrowthSecondManaCircleScene scene;

		public bool isDragging;

		protected BoxCollider touchCollider;

		private Vector2 beginDragPosition;

		private Vector2 lastDragPosition;

		private bool isVerticalDragging;

		private bool isHorizontalDragging;

		private const float resolutionFixRate = 100f;

		private const float minMoveDelta = 0f;

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
