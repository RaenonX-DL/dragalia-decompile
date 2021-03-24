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
	public class GrowthManaCircleDraggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		public GrowthManaCircleScene scene;
		public bool isDragging;
		protected BoxCollider touchCollider;
		private Vector2 beginDragPosition;
		private Vector2 lastDragPosition;
		private bool isVerticalDragging;
		private bool isHorizontalDragging;
		private const float resolutionFixRate = 100f;
		private const float minMoveDelta = 0f;
	
		// Constructors
		public GrowthManaCircleDraggable();
	
		// Methods
		protected virtual void NotifyDraggingToScene(bool arg);
		public void OnBeginDrag(PointerEventData eventData);
		public void OnDrag(PointerEventData eventData);
		public void OnEndDrag(PointerEventData eventData);
	}
}
