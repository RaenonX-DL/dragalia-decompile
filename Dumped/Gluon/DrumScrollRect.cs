using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Gluon
{
	public class DrumScrollRect : DragEventScrollRect
	{
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

		public int CurrentTopIndex => default(int);

		private float AnchoredPosition => default(float);

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public void InitSetting(bool enableScrollControll)
		{
		}

		public float GetHeadScrollCellCount()
		{
			return default(float);
		}

		public float GetTailScrollCellCount()
		{
			return default(float);
		}

		public void SetHeadScrollCellCount(float scrollCell)
		{
		}

		public void SetTailScrollCellCount(float scrollCell)
		{
		}
	}
}
