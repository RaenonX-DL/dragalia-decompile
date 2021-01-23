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
	public class RecoverStaminaMultiItemListCell : TableViewCell<Gluon.RecoverStaminaMultiItemData>
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text itemName;
		public CommonSliderSelection slider;
		[HideInInspector]
		public RecoverStaminaMultiItemListController controller;
	
		// Constructors
		public RecoverStaminaMultiItemListCell();
	
		// Methods
		private void Start();
		public void OnSliderValueChanged(float val);
		public override void UpdateContent(RecoverStaminaMultiItemData itemData);
		private void LateUpdate();
	}
}
