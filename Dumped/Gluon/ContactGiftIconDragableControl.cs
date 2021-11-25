using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class ContactGiftIconDragableControl : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[NonSerialized]
		public ContactShopPanel shopPanel;

		private ContactGiftIcon icon;

		private void Awake()
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
