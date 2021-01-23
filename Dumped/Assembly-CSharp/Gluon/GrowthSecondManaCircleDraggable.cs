/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthSecondManaCircleDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		public GrowthSecondManaCircleScene scene;
		public bool isDragging;
		protected BoxCollider touchCollider;
		private Vector2 beginDragPosition;
		private Vector2 lastDragPosition;
		private bool isVerticalDragging;
		private bool isHorizontalDragging;
		private const float resolutionFixRate = 100f;
		private const float minMoveDelta = 0f;
	
		// Constructors
		public GrowthSecondManaCircleDraggable();
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
	}
}
