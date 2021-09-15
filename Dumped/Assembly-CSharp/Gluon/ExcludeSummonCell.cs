/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExcludeSummonCell : TableViewCell<Gluon.ExcludeSummonCellData>
	{
		// Fields
		[SerializeField]
		private Transform unitIconTrans;
		[SerializeField]
		private UnityEngine.UI.Text unitNameText;
		[SerializeField]
		private UnityEngine.UI.Text detailText;
		[SerializeField]
		public Toggle excludeToggle;
		[SerializeField]
		public PointerEventHandler pointerToggle;
		[SerializeField]
		public CheckBoxAnimation checkBoxAnimation;
		private ExcludeSummonCellData excludeSummonCellData;
	
		// Constructors
		public ExcludeSummonCell();
	
		// Methods
		public override void UpdateContent(ExcludeSummonCellData itemData);
		public void UpdateToggle();
		public void UnitGetButtonSetting(bool isSetting);
		public void OnUnitGetButtonSetting();
	}
}
