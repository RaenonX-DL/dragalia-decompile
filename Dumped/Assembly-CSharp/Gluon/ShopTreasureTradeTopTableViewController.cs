/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTreasureTradeTopTableViewController : TableViewController<Gluon.ShopTradeModel.TreasureTradeTopData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text noTreasureText;
		private float cellHeight;
		private List<SimpleAnimationCell> animationCellList;
	
		// Constructors
		public ShopTreasureTradeTopTableViewController();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		protected override TableViewCell<ShopTradeModel.TreasureTradeTopData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		protected override void UpdateContents();
	}
}
