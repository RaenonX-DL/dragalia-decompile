/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ClearPartyEquipSampleListController : TableViewController<Gluon.ClearPartyEquipSampleListCellData>
	{
		// Fields
		public Action<ClearPartyEquipSampleListCellData> setButtonCallBack;
		public float cellWidth;
		public float cellHeight;
	
		// Constructors
		public ClearPartyEquipSampleListController();
	
		// Methods
		public void LoadList();
		protected override TableViewCell<ClearPartyEquipSampleListCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		[CompilerGenerated]
		private void _CreateCellForIndex_b__4_0(int cellIndex);
	}
}
