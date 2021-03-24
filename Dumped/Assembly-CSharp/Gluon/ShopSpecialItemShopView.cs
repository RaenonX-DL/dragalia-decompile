/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopSpecialItemShopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public ShopCommonTableViewController tableview;
	
		// Constructors
		public ShopSpecialItemShopView();
	
		// Methods
		public static ShopSpecialItemShopView Create(Transform parent, ShopTradeScene scene);
		private void Awake();
		private void Start();
		private static void ReloadData();
		public void ReloadPage();
		public override void RefreshCurrentPage();
		public override void ScrollToItem(int tradeId);
	}
}
