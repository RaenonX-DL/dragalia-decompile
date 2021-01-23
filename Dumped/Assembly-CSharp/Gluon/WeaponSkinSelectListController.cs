/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WeaponSkinSelectListController : TableViewController<Gluon.CommonIconListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonCallBack;
		public UnityAction outButtonCallBack;
		public CommonIconListBase iconListBase;
		private int nowWeaponSkinId;
		private const int paddingBottomLayoutHeight = 80;
	
		// Properties
		public int CellCount { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public WeaponSkinSelectListController __4__this;
			public TableViewCell<CommonIconListCellData> cell;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _CreateCellForIndex_b__0(int cellIndex);
		}
	
		// Constructors
		public WeaponSkinSelectListController();
	
		// Methods
		protected override void Start();
		public void LoadSkinData(int[] weaponSkinIds);
		protected override TableViewCell<CommonIconListCellData> CreateCellForIndex(int index);
		public void SetSelectCell(CommonIconListCellData data, CommonIconListCellData.State state, bool setUpdateFlag);
		public void ReloadCellByUpdateFlag();
		public CommonIconListCellData GetSelectData();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
