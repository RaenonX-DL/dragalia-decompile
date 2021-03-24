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
	public class ShopTradeTableViewController : TableViewController<Gluon.ShopTradeProductData.TradeShopItemData>
	{
		// Fields
		public ShopTradeProductData.TradeShopType shopType;
		public string originalCellPrefabPath;
		[Header]
		[SerializeField]
		public Transform sortButtonParent;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text noTradeItemText;
		public UnityEngine.UI.Text noTradeByFilterItemText;
		private float cellHeight;
		private List<SimpleAnimationCell> animationCellList;
		private List<ShopTradeProductData.TradeShopItemData> originalData;
		private ShopTradeModel.FilterCondition filterCondition;
		private const int paddingBottomLayoutHeight = 80;
		private bool stopRecordNewState;
		private CommonSortButton sortButton;
		private const string sortButtonPrefabPath = "UI/Buttons/SortButton";
	
		// Constructors
		public ShopTradeTableViewController();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public void SetFitlerTab(int tab);
		protected void ReloadTableData();
		protected void OnFilterApplied(ShopTradeModel.FilterCondition condition);
		protected override TableViewCell<ShopTradeProductData.TradeShopItemData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void ApplySortToData(List<ShopTradeProductData.TradeShopItemData> originalData, ShopTradeModel.FilterCondition filterCondition);
		protected override void UpdateContents();
		public void ReloadPage();
		[CompilerGenerated]
		private void _Start_b__14_0();
	}
}
