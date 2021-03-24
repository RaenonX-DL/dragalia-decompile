/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PageScrollRect : DragEventScrollRect
	{
		// Fields
		public int startPage;
		public int maxPage;
		public float smooth;
		public float pageSwipeOffset;
		public bool loopPage;
		public UnityAction<int> changePage;
		private Vector2 targetPosition;
		private float hPerPage;
		public int nowIndex;
		private int hIndex;
		private int horizontalPages;
		private Vector2 oldNormalizedPosition;
		private Vector2 moveStartPosition;
		private bool isMoveLeft;
		private const float boundMarginX = 0.02f;
	
		// Constructors
		public PageScrollRect();
	
		// Methods
		private new void Awake();
		private new void Start();
		public override void OnBeginDrag(PointerEventData eventData);
		public override void OnEndDrag(PointerEventData eventData);
		private void MovePageAnimation(float posx);
		private void MoveAnimationComplete();
		private void UpdateIndex();
		private Vector2 GetSnapPosition();
		public void NextPageChange(int nextPage);
		private void SetMovePageAnimation();
		public void SetMaxPage(int max);
		[CompilerGenerated]
		private void _SetMovePageAnimation_b__24_0();
	}
}
