/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class PopupIconListView : TableViewController<Gluon.PopupIconListData>
	{
		// Fields
		public const float cellHeight = 128f;
		[CompilerGenerated]
		private PopupItemList _rootScene_k__BackingField;
		public PopupIconViewCell iconViewCell;
		private GiftType showGiftType;
		private PopupIconListData.IconListData[] itemList;
	
		// Properties
		public PopupItemList rootScene { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PopupIconListView();
	
		// Methods
		public void SetItemList(PopupIconListData.IconListData[] setList);
		protected override void Start();
		public void SetData();
		private void LoadData();
		protected override float GetCellHeightAtIndex(int index);
	}
}
