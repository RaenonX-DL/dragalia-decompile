/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class FriendListController : TableViewController<Gluon.FriendListCellData>
	{
		// Fields
		public const float cellHeight = 148f;
		public UnityEngine.UI.Text NoFriendText;
		public CommonSortButton sortButton;
		private const int paddingBottomLayoutHeight = 80;
	
		// Constructors
		public FriendListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<FriendListCellData> cellList);
		protected override TableViewCell<FriendListCellData> CreateCellForIndex(int index);
		public void RemoveCellData(FriendListCellData data);
		protected override float GetCellHeightAtIndex(int index);
		public void Reload();
	}
}
