/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftTargetSelectListController : TableViewController<Gluon.CraftTargetSelectCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public UnityAction<CraftTargetSelectCellData, bool> craftCellCallBack;
		public UnityAction<CraftTargetSelectCellData> treeCallBack;
		public List<int> breakNewFlagList;
		public TutorialDataManager.GrowthTutorialType tutorialType;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<WeaponCraftGroupElement, int> __9__7_0;
			public static Func<WeaponCraftGroupElement, int> __9__7_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadCraftData_b__7_0(WeaponCraftGroupElement p);
			internal int _LoadCraftData_b__7_1(WeaponCraftGroupElement p);
		}
	
		// Constructors
		public CraftTargetSelectListController();
	
		// Methods
		protected override void Start();
		public void LoadCraftData(WeaponCraftGroupElement[] datas, bool isShowRootInfo);
		protected override TableViewCell<CraftTargetSelectCellData> CreateCellForIndex(int index);
		public void ClearList();
		public void UpdateShowRootFlag(bool flag);
		private int[] GetRootFinalWeaponList(WeaponCraftTreeElement craftTreeData);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__8_0(int dataIndex);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__8_1(int dataIndex);
	}
}
