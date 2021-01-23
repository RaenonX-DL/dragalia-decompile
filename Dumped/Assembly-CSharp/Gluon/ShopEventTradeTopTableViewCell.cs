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
	public class ShopEventTradeTopTableViewCell : TableViewCell<Gluon.ShopTradeModel.EventTradeTopData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text beginTimeText;
		public UnityEngine.UI.Text endTimeText;
		public GameObject dateGO;
		public UnityEngine.UI.Text beginEndText;
		public Image banner;
		private ShopEventTradeShopTopView panel;
		private ShopTradeExchangeTopView exchangePanel;
		private ShopTradeModel.EventTradeTopData data;
	
		// Constructors
		public ShopEventTradeTopTableViewCell();
	
		// Methods
		private void Start();
		public override void UpdateContent(ShopTradeModel.EventTradeTopData data);
		private string CreateBannerSpritePath();
		public void OnBannerPressed();
	}
}
