/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DrumScrollRect : DragEventScrollRect
	{
		// Fields
		public GameObject drumScrollCell;
		public int scrollItemCount;
		public int instantateItemCount;
		public UnityAction<int, GameObject> onUpdateItem;
		private float inertiaStopSpeed;
		private float InertiaStopRange;
		private float inertiaScrollSpeedMin;
		private float slowScrollSpeed;
		public int prevCurrentIndex;
		private float cellHeight;
		private float originalDeclarationRate;
		private List<GameObject> drumCells;
		private int scrollShiftNum;
		private float diffPreFramePosition;
		private RectTransform rectTransform;
		private bool enableScrollControll;
	
		// Properties
		public int CurrentTopIndex { get; }
		private float AnchoredPosition { get; }
	
		// Constructors
		public DrumScrollRect();
	
		// Methods
		protected override void Start();
		private new void Update();
		public override void OnBeginDrag(PointerEventData eventData);
		public override void OnEndDrag(PointerEventData eventData);
		public void InitSetting(bool enableScrollControll);
		public float GetHeadScrollCellCount();
		public float GetTailScrollCellCount();
		public void SetHeadScrollCellCount(float scrollCell);
		public void SetTailScrollCellCount(float scrollCell);
	}
}
