/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class MyPagePresentGroupListController : TableViewController<Gluon.MyPagePresentGroupListCellData>
	{
		// Fields
		public static int sceneButtonOpenedCellDataIndex;
		public const float cellHeight = 100f;
	
		// Constructors
		public MyPagePresentGroupListController();
		static MyPagePresentGroupListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<MyPagePresentGroupListCellData> cellList);
		protected override float GetCellHeightAtIndex(int index);
	}
}
