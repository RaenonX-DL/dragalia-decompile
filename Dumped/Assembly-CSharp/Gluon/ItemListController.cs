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
	public class ItemListController : TableViewController<Gluon.ItemListCellData>
	{
		// Fields
		public float cellWidth;
		public float cellHeight;
		public float captionHeight;
		public float fundsHeight;
		public float messageTextHeight;
		public UnityEngine.UI.Text noItemText;
		private int captionNum;
		private int fundsNum;
		private int textNum;
	
		// Constructors
		public ItemListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<ItemListCellData> cellList);
		protected override TableViewCell<ItemListCellData> CreateCellForIndex(int index);
		protected override void UpdateContentSize();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
