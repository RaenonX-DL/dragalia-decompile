/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactGiftIconDragableControl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
	{
		// Fields
		[NonSerialized]
		public ContactShopPanel shopPanel;
		private ContactGiftIcon icon;
	
		// Constructors
		public ContactGiftIconDragableControl();
	
		// Methods
		private void Awake();
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
	}
}
