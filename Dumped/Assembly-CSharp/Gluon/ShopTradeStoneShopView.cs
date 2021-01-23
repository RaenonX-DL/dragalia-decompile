/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeStoneShopView : ShopTradePanelBase
	{
		// Fields
		public Transform frameParent;
		public RectTransform referenceRect;
	
		// Constructors
		public ShopTradeStoneShopView();
	
		// Methods
		public static ShopTradeStoneShopView Create(Transform parent, ShopTradeScene scene);
		private void Start();
		private void OnDestroy();
		public void ReloadPage();
		public override void RefreshCurrentPage();
		[CompilerGenerated]
		private void _Start_b__3_0();
	}
}
