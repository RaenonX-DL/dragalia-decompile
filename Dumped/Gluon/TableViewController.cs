using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TableViewController<T> : MonoBehaviour
	{
		protected class CaptionLineInfo
		{
			public GameObject itemGO;

			public int lineIndex;

			public float height;
		}

		protected List<T> tableData;

		[SerializeField]
		protected GameObject originalCell;

		[SerializeField]
		protected Transform parentTransform;

		protected Rect visibleRect;

		protected LinkedList<TableViewCell<T>> cellList;

		protected RectTransform rectTransform;

		protected ScrollRect scrollRect;

		[SerializeField]
		protected int listLine;

		[SerializeField]
		protected RectOffset listPadding;

		[SerializeField]
		protected Vector2 listSpacing;

		[SerializeField]
		protected GameObject[] doNotDestroyListOnClearContent;

		protected int additionalSizeForInitialCreate;

		protected bool onAddCellForIndex;

		protected List<CaptionLineInfo> captionList;

		private Vector2 prevScrollPos;

		private bool lastUpdateAfterStartDone;

		private bool isBound;

		public Action<bool> boundCallBack;

		private bool isAwaked;

		[SerializeField]
		protected bool isParentSizeReference;

		protected float parentSizeHeight;

		protected bool isReuseVariableHeightCells;

		private int limitCreateCellsCount;

		public bool LastUpdateAfterStartDone => default(bool);

		public int GetColumnCount()
		{
			return default(int);
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual TableViewCell<T> CreateCellForIndex(int index)
		{
			return null;
		}

		protected void UpdateCellForIndex(TableViewCell<T> cell, int index)
		{
		}

		public void ClearCaptionList()
		{
		}

		public void AddCaptionItem(GameObject itemGO, int lineIndex, float height)
		{
		}

		protected virtual float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected virtual float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}

		protected virtual void UpdateContentSize()
		{
		}

		protected virtual void UpdateVisibleRect()
		{
		}

		public void ReloadContents()
		{
		}

		protected virtual void ClearContents()
		{
		}

		protected virtual void UpdateContents()
		{
		}

		protected void FillVisibleRectWithCells()
		{
		}

		public void ContinueFillVisibleRectWithCells()
		{
		}

		public void SetLimitCreateCellsCount(int count)
		{
		}

		public void ResetLimitCreateCellsCount()
		{
		}

		public bool IsEnableLimitCreateCellsCount()
		{
			return default(bool);
		}

		public void OnScrollPosChanged(Vector2 scrollPos)
		{
		}

		protected virtual void ReuseCells(int scrollDirection)
		{
		}

		protected void SetupGridLayout(int line, RectOffset padding, Vector2 spacing)
		{
		}

		protected virtual Vector2 GetNextCellPos(TableViewCell<T> cell, int increment)
		{
			return default(Vector2);
		}

		protected void ClearCellsList()
		{
		}

		public bool IsCellInVisibleRect(TableViewCell<T> cell)
		{
			return default(bool);
		}

		private void ReuseVariableHeightCells(int scrollDirection)
		{
		}

		private TableViewCell<T> AddCellForIndex(int index)
		{
			return null;
		}

		public virtual bool IsScrollOutOfTopRange()
		{
			return default(bool);
		}

		public virtual bool IsScrollOutOfBottomRange()
		{
			return default(bool);
		}

		public void SetScrollLock(bool isVerticalLock)
		{
		}
	}
}
