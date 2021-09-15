/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonDualListTableViewController : CommonIconListController
	{
		// Fields
		[Header]
		protected int iconListLine;
		protected RectOffset iconListPadding;
		protected Vector2 iocnListSpacing;
		protected GameObject iconOriginalCell;
		protected Vector2 iconCellSize;
		[Header]
		[SerializeField]
		protected int cellListLine;
		[SerializeField]
		protected RectOffset cellListPadding;
		[SerializeField]
		protected Vector2 cellListSpacing;
		private GameObject[] listOriginalCells;
		[SerializeField]
		protected UnityEngine.UI.Text changeListText;
		[SerializeField]
		protected CommonTagSearch tagSearch;
		protected List<CommonIconListCellData> originalTableData;
		[CompilerGenerated]
		private ulong[] _originalKeyIdList_k__BackingField;
		private bool preventOnModelChanged;
		private bool preventNextClearText;
		private Coroutine inputFilterChangedCoroutine;
		private int oldFilterIdCount;
		public bool isShowIconList;
	
		// Properties
		public ulong[] originalKeyIdList { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int tableCount { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public List<int> filteredId;
			public Func<ulong, bool> __9__1;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal List<ulong> _UpdateSerchTargetList_b__0(List<ulong> l);
			internal bool _UpdateSerchTargetList_b__1(ulong x);
		}
	
		[CompilerGenerated]
		private sealed class _UpdateSerchTargetList_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public List<int> filteredId;
			public CommonDualListTableViewController __4__this;
			private __c__DisplayClass33_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateSerchTargetList_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CommonDualListTableViewController();
	
		// Methods
		protected override void Awake();
		public virtual void ReloadIconListLayout(CommonDualListType listType = CommonDualListType.Amulet);
		public void SetListChangeButtonText(CommonDualListType type);
		public void ReloadInfoListLayout(CommonDualListType type);
		public virtual void OnListTypeReloaded();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		private GameObject GetOriginCellObject(CommonDualListType type);
		protected void OnModelChangedForInputFilter();
		private void OnInputFilterChanged(List<int> filteredId);
		[IteratorStateMachine]
		private IEnumerator UpdateSerchTargetList(List<int> filteredId);
		private void ClearInputFilter();
		protected void UpdateSearchInputFilter();
	}
}
