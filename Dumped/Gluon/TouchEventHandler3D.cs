using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class TouchEventHandler3D : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		public TouchUnityEvent onBeginDrag;

		public TouchUnityEvent onCancel;

		public TouchUnityEvent onDeselect;

		public TouchUnityEvent onDrag;

		public TouchUnityEvent onDrop;

		public TouchUnityEvent onEndDrag;

		public TouchUnityEvent onInitializePotentialDrag;

		public TouchUnityEvent onMove;

		public TouchUnityEvent onPointerClick;

		public TouchUnityEvent onPointerDown;

		public TouchUnityEvent onPointerEnter;

		public TouchUnityEvent onPointerExit;

		public TouchUnityEvent onPointerUp;

		public TouchUnityEvent onScroll;

		public TouchUnityEvent onSelect;

		public TouchUnityEvent onSubmit;

		public TouchUnityEvent onUpdateSelected;

		private void InvokeUnityEvent(TouchUnityEvent unityEvent, BaseEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnCancel(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnDrop(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnScroll(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnUpdateSelected(BaseEventData eventData)
		{
		}
	}
}
