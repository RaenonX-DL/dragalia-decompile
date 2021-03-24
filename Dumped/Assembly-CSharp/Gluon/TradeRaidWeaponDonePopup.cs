/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TradeRaidWeaponDonePopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject tapButtonObject;
		public Camera flashCamera;
		public RawImageWithAlphaBlend rawImage;
		private ShopTradeProductData.TradeShopItemData data;
		private Action onDone;
		private string flashBasePath;
		private string flashCompletePath;
		private TouchGuardObject touchGuardObj;
		private FlRoot root;
		private FlRoot topRoot;
	
		// Constructors
		public TradeRaidWeaponDonePopup();
	
		// Methods
		public static TradeRaidWeaponDonePopup Create(ShopTradeProductData.TradeShopItemData data, Action onDone);
		protected override void Start();
		public void OnTapButtonPressed();
		[CompilerGenerated]
		private void _Start_b__11_0();
		[CompilerGenerated]
		private void _OnTapButtonPressed_b__12_0();
	}
}
