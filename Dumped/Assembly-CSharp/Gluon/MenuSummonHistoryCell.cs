/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuSummonHistoryCell : TableViewCell<Gluon.MenuSummonHistoryCellData>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text unitName;
		[SerializeField]
		private UnityEngine.UI.Text historyDataTime;
	
		// Constructors
		public MenuSummonHistoryCell();
	
		// Methods
		public override void UpdateContent(MenuSummonHistoryCellData itemData);
		public void OnSummonDetailButtonClick();
	}
}
