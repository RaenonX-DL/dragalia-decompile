using System;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class DragonStrokePointerEventHandler : PointerEventHandler, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public Action onBeginDrag;

		public Action onEndDrag;

		private bool isDrag;

		private PointerEventData currentEventData;

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}
	}
}
