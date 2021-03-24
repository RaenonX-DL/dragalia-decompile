/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopEventTradeTopTableViewController : TableViewController<Gluon.ShopTradeModel.EventTradeTopData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text noEventText;
		private float cellHeight;
		private List<SimpleAnimationCell> animationCellList;
	
		// Constructors
		public ShopEventTradeTopTableViewController();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		protected override TableViewCell<ShopTradeModel.EventTradeTopData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override void UpdateContents();
	}
}
