/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalCharaSkinIconListController : TableViewController<Gluon.CommonIconListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public CommonIconListBase iconListBase;
		[HideInInspector]
		public int selectCharaSkinId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public BattleRoyalCharaSkinIconListController __4__this;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _CreateCellForIndex_b__0(int cellIndex);
			internal void _CreateCellForIndex_b__1(int cellIndex);
		}
	
		// Constructors
		public BattleRoyalCharaSkinIconListController();
	
		// Methods
		public void LoadSkinData(ulong[] charaSkinIds);
		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index);
		public void UpdateSelectCell();
		public void Reload();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
