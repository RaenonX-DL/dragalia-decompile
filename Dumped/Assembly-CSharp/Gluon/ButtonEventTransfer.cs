/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ButtonEventTransfer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		// Fields
		public GameObject target;
		private PointerEventHandler handler;
		private EventTrigger trigger;
		private Button button;
	
		// Constructors
		public ButtonEventTransfer();
	
		// Methods
		private void Awake();
		public void OnPointerClick(PointerEventData eventData);
		public void OnSubmit(BaseEventData eventData);
		public void OnPointerDown(PointerEventData eventData);
		public void OnPointerEnter(PointerEventData eventData);
		public void OnPointerExit(PointerEventData eventData);
		public void OnPointerUp(PointerEventData eventData);
		public void OnSelect(BaseEventData eventData);
		public void OnInitializePotentialDrag(PointerEventData eventData);
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
		public void OnDrop(PointerEventData eventData);
		public void OnScroll(PointerEventData eventData);
		public void OnUpdateSelected(BaseEventData eventData);
		public void OnCancel(BaseEventData eventData);
		public void OnDeselect(BaseEventData eventData);
		public void OnMove(AxisEventData eventData);
	}
}
