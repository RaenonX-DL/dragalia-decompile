/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TradeMaterialAmuletConfirmPopup : ShopCommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text confirmText;
		[SerializeField]
		private UnityEngine.UI.Text needDew;
		[SerializeField]
		private UnityEngine.UI.Text curDewText;
		[SerializeField]
		private UnityEngine.UI.Text afterDewText;
		[SerializeField]
		private UnityEngine.UI.Text errorText;
		[SerializeField]
		private Button tradeButton;
		[SerializeField]
		private ShopTableViewTradeAmuletCell amuletCell;
		private ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data;
		private bool canExchangeCrest;
		private int needDewPoint;
		private string crestName;
	
		// Constructors
		public TradeMaterialAmuletConfirmPopup();
	
		// Methods
		public static TradeMaterialAmuletConfirmPopup Create(ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data);
		private void Init(ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data);
		private void UpdateUI(bool canExchangeCrest);
		public void OnExchangeButtonTouched();
		private void OnItemTradeSuccess(AbilityCrestTradeTradeResponse response);
	}
}
