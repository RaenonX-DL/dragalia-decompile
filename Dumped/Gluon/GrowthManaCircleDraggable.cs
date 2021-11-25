using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class GrowthManaCircleDraggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public GrowthManaCircleScene scene;

		public bool isDragging;

		protected BoxCollider touchCollider;

		private Vector2 beginDragPosition;

		private Vector2 lastDragPosition;

		private bool isVerticalDragging;

		private bool isHorizontalDragging;

		private const float resolutionFixRate = 100f;

		private const float minMoveDelta = 0f;

		protected virtual void NotifyDraggingToScene(bool arg)
		{
		}

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
