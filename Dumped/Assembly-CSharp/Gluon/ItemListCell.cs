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
	public class ItemListCell : TableViewCell<Gluon.ItemListCellData>
	{
		// Fields
		[SerializeField]
		private CommonIcon itemIcon;
		[SerializeField]
		private GameObject captionBase;
		[SerializeField]
		private UnityEngine.UI.Text captionText;
		[SerializeField]
		private GameObject fundsBase;
		[SerializeField]
		private UnityEngine.UI.Text rupyText;
		[SerializeField]
		private UnityEngine.UI.Text manaText;
		[SerializeField]
		private UnityEngine.UI.Text dewText;
		[SerializeField]
		private UnityEngine.UI.Text messageText;
		private ItemListCellData cellData;
	
		// Constructors
		public ItemListCell();
	
		// Methods
		public override void UpdateContent(ItemListCellData data);
		public void OnIconButtonPressed();
	}
}
