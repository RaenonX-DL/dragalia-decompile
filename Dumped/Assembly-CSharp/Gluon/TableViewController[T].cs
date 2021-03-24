/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class TableViewController<T> : MonoBehaviour
	{
		// Fields
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
	
		// Properties
		public bool LastUpdateAfterStartDone { get; }
	
		// Nested types
		protected class CaptionLineInfo
		{
			// Fields
			public GameObject itemGO;
			public int lineIndex;
			public float height;
	
			// Constructors
			public CaptionLineInfo();
		}
	
		// Constructors
		public TableViewController();
	
		// Methods
		public int GetColumnCount();
		protected virtual void Awake();
		protected virtual void Start();
		protected virtual void LateUpdate();
		protected virtual TableViewCell<T> CreateCellForIndex(int index);
		protected void UpdateCellForIndex(TableViewCell<T> cell, int index);
		public void ClearCaptionList();
		public void AddCaptionItem(GameObject itemGO, int lineIndex, float height);
		protected virtual float GetCellHeightAtIndex(int index);
		protected virtual float GetCellWidthAtIndex(int index);
		protected virtual void UpdateContentSize();
		protected virtual void UpdateVisibleRect();
		public void ReloadContents();
		protected virtual void ClearContents();
		protected virtual void UpdateContents();
		protected void FillVisibleRectWithCells();
		public void ContinueFillVisibleRectWithCells();
		public void SetLimitCreateCellsCount(int count);
		public void ResetLimitCreateCellsCount();
		public bool IsEnableLimitCreateCellsCount();
		public void OnScrollPosChanged(Vector2 scrollPos);
		protected virtual void ReuseCells(int scrollDirection);
		protected void SetupGridLayout(int line, RectOffset padding, Vector2 spacing);
		protected virtual Vector2 GetNextCellPos(TableViewCell<T> cell, int increment);
		protected void ClearCellsList();
		public bool IsCellInVisibleRect(TableViewCell<T> cell);
		private void ReuseVariableHeightCells(int scrollDirection);
		private TableViewCell<T> AddCellForIndex(int index);
		public virtual bool IsScrollOutOfTopRange();
		public virtual bool IsScrollOutOfBottomRange();
		public void SetScrollLock(bool isVerticalLock);
	}
}
