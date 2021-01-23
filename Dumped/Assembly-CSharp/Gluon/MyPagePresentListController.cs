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
	public class MyPagePresentListController : TableViewController<Gluon.MyPagePresentListCellData>
	{
		// Fields
		public UnityEngine.UI.Text NoPresentText;
		public const float cellHeight = 168f;
	
		// Constructors
		public MyPagePresentListController();
	
		// Methods
		protected override void Awake();
		protected override TableViewCell<MyPagePresentListCellData> CreateCellForIndex(int index);
		public void LoadData(List<MyPagePresentListCellData> cellList);
		public void ReloadData(List<MyPagePresentListCellData> cellList);
		protected override float GetCellHeightAtIndex(int index);
	}
}
