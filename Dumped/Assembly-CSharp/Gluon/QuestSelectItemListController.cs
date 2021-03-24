/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectItemListController : TableViewController<Gluon.ItemListCellData>
	{
		// Fields
		public const float cellHeight = 150f;
	
		// Constructors
		public QuestSelectItemListController();
	
		// Methods
		public void LoadData(List<ItemListCellData> cellList);
		protected override float GetCellHeightAtIndex(int index);
	}
}
