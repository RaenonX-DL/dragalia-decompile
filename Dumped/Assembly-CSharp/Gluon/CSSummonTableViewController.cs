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
	public class CSSummonTableViewController : TableViewController<Gluon.SummonTopData.SwitchableSummonInfo>
	{
		// Fields
		private float cellHeight;
		private List<SimpleAnimationCell> animationCellList;
	
		// Constructors
		public CSSummonTableViewController();
	
		// Methods
		protected override TableViewCell<SummonTopData.SwitchableSummonInfo> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void ReloadByData(List<SummonTopData.SwitchableSummonInfo> data);
	}
}
