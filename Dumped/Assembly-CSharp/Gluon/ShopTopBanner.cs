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
	public class ShopTopBanner : MonoBehaviour
	{
		// Fields
		public Image image;
		public GameObject buttonObj;
		public Button button;
		public MaintenanceButtonController maintenanceButton;
		private ShopTopBannerModel.BannerData data;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ShopTradePanelBase> __9__8_0;
			public static Action<ShopTradePanelBase> __9__8_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnPressed_b__8_0(ShopTradePanelBase page);
			internal void _OnPressed_b__8_1(ShopTradePanelBase page);
		}
	
		// Constructors
		public ShopTopBanner();
	
		// Methods
		public void UpdateByData(ShopTopBannerModel.BannerData data, bool hideButton = false);
		public static void SetMaintenanceButtonWithPanelType(MaintenanceButtonController button, ShopTradeModel.PanelType panel);
		public static List<MaintenanceFunctionType> GetMaintenaceTypeListWithPanelName(ShopTradeModel.PanelType panel);
		public void OnPressed();
	}
}
