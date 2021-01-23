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
	public class ReceivedOverLimitListController : TableViewController<Gluon.ReceivedOverLimitListCellData>
	{
		// Fields
		public const float cellHeight = 100f;
	
		// Constructors
		public ReceivedOverLimitListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<ReceivedOverLimitListCellData> cellList);
		protected override float GetCellHeightAtIndex(int index);
	}
}
