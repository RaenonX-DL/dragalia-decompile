/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RecoverStaminaMultiItemListController : TableViewController<Gluon.RecoverStaminaMultiItemData>
	{
		// Fields
		[Header]
		[SerializeField]
		public RecoverStaminaMultipleItemConfirmPopup popup;
		private float cellWidth;
		private float cellHeight;
	
		// Constructors
		public RecoverStaminaMultiItemListController();
	
		// Methods
		protected override void Awake();
		public void LoadData(List<RecoverStaminaMultiItemData> data);
		protected override TableViewCell<RecoverStaminaMultiItemData> CreateCellForIndex(int index);
		public bool IsAnyItemSelectable(out bool isAnySliderAvailable);
		public void OnAnySliderValueChanged(int diffVal);
		public EntityData[] GetSelectedItems();
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
	}
}
