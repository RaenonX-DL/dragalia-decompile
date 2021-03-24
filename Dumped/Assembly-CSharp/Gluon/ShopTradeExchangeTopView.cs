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
	public class ShopTradeExchangeTopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		public ShopTreasureTradeTopTableViewController normalTableView;
		public ShopEventTradeTopTableViewController eventTableView;
		private static TabType lastSelectedTab;
		private TabType currentTabType;
	
		// Nested types
		private enum TabType
		{
			None = 0,
			Normal = 1,
			Event = 2
		}
	
		// Constructors
		public ShopTradeExchangeTopView();
	
		// Methods
		public static ShopTradeExchangeTopView Create(Transform parent, ShopTradeScene scene);
		private void Awake();
		private void Start();
		public void OnSwitchTab(int tabIndex, bool calledFromUI);
		private void LoadTabs();
		public void OnTreasureCellButtonPressed(int groupId);
		public void OnEventCellButtonPressed(int groupId);
		public static void ClearLastSelectedTab();
		private void DisableButtonForReason(GameObject tab, TutorialUIManager.LockButtonType type);
	}
}
