/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopSustainableTopButton : MonoBehaviour
	{
		// Fields
		public ShopTradeProductData.CommonShopItemData.PackContentType contentType;
		public UnityEngine.UI.Text remainText;
		public GameObject badge;
		private Button button;
		private bool preOrderable;
		private ShopTradeModel.ShopTopData.SustainableBonusData data;
	
		// Nested types
		public enum Status
		{
			NotPurchased = 0,
			Claimable = 1,
			Claimed = 2
		}
	
		// Constructors
		public ShopSustainableTopButton();
	
		// Methods
		private void Start();
		private void SetupByRemainings();
		private void Update();
		private void SetAsInactive();
		public void OnButtonPressed();
		private void CreateClaimedPopup(bool isChargeDone);
		public static string CreateRenewalRemainDaysComment(int remainDays, long endUnixTime);
		[CompilerGenerated]
		private void _OnButtonPressed_b__11_1(ShopGetBonusResponse res);
		[CompilerGenerated]
		private void _OnButtonPressed_b__11_0();
		[CompilerGenerated]
		private void _OnButtonPressed_b__11_2(ShopGetBonusResponse res);
		[CompilerGenerated]
		private void _CreateClaimedPopup_b__12_0();
	}
}
