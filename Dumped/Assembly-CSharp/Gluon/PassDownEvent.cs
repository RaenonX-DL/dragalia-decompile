/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PassDownEvent : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject[] passTargets;
		private List<RaycastResult> raycastResults;
		private List<GameObject> lowerObjects;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0<T>
			where T : IEventSystemHandler
		{
			// Fields
			public int i;
			public PassDownEvent __4__this;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal bool _PassEvent_b__0(GameObject item);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public int i;
			public PassDownEvent __4__this;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal bool _GetLowerObjects_b__0(GameObject item);
		}
	
		// Constructors
		public PassDownEvent();
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
		public void OnPointerClick(PointerEventData eventData);
		public void OnPointerDown(PointerEventData eventData);
		public void OnPointerUp(PointerEventData eventData);
		public void PassEvent<T>(PointerEventData data, ExecuteEvents.EventFunction<T> function)
			where T : IEventSystemHandler;
		private void GetLowerObjects(PointerEventData data, List<GameObject> lowerObjects);
	}
}
