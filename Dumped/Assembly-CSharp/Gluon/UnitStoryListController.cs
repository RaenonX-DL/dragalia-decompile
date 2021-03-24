/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class UnitStoryListController : TableViewController<Gluon.UnitStoryListCellData>
	{
		// Fields
		public UnityEngine.UI.Text noStoryText;
		public CommonSortButton sortButton;
		public bool isCastleStory;
		private List<SimpleAnimationCell> animationCellList;
		public const float cellHeight = 148f;
		public const float castleCellHeight = 124f;
		private const float scrollsec = 1f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public UnitStoryListController __4__this;
			public float lastPos;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _SetScrollForCellIndex_b__0(float fade);
		}
	
		// Constructors
		public UnitStoryListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<UnitStoryListCellData> cellList);
		protected override float GetCellHeightAtIndex(int index);
		public void SetScrollForCellIndex(int index);
		public void Reload();
		protected override TableViewCell<UnitStoryListCellData> CreateCellForIndex(int index);
		public void ResetScroll();
	}
}
