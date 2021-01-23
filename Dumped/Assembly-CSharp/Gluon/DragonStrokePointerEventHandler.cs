/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonStrokePointerEventHandler : PointerEventHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		public Action onBeginDrag;
		public Action onEndDrag;
		private bool isDrag;
		private PointerEventData currentEventData;
	
		// Constructors
		public DragonStrokePointerEventHandler();
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
		private new void OnApplicationPause(bool pause);
	}
}
