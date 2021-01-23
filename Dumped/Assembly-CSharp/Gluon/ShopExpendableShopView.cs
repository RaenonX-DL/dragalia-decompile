/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopExpendableShopView : ShopTradePanelBase
	{
		// Fields
		public Transform frameParent;
		public RectTransform referenceRect;
		[Header]
		[SerializeField]
		public TabBase tabController;
		[Header]
		[SerializeField]
		public ShopCommonTableViewController[] tableviews;
		private TabType currentTabType;
		private bool shopInitialized;
	
		// Nested types
		private enum TabType
		{
			None = 0,
			Diamond = 1,
			Stamina = 2,
			Storage = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__10_0;
			public static Func<bool> __9__11_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ReloadDiamondDataWait_b__10_0();
			internal bool _Start_b__11_1();
		}
	
		[CompilerGenerated]
		private sealed class _ReloadDiamondDataWait_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReloadDiamondDataWait_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShopExpendableShopView __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShopExpendableShopView();
	
		// Methods
		public static ShopExpendableShopView Create(Transform parent, ShopTradeScene scene);
		private void Awake();
		public void OnSwitchTab(int tabIndex, bool calledFromUI);
		[IteratorStateMachine]
		private IEnumerator ReloadDiamondDataWait();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void LoadTabs();
		private static void ReloadData();
		private void OnDestroy();
		public void ReloadPage();
		public override void RefreshCurrentPage();
		public void OnExtendWeaponQuantityButtonPressed();
		private void CreateExceedWeaponLimitPopup();
		private void CreateWeaponExtensionPopup();
		private void CheckStoneForWeaponExtension(bool isPaidStone);
		public void OnExtendDragonQuantityButtonPressed();
		private void CreateExceedDragonLimitPopup();
		private void CreateDragonExtensionPopup();
		private void CheckStoneForDragonExtension(bool isPaidStone);
		public void OnExtendAmuletQuantityButtonPressed();
		private void CreateExceedAmuletLimitPopup();
		private void CreateAmuletExtensionPopup();
		private void CheckStoneForAmuletExtension(bool isPaidStone);
		[CompilerGenerated]
		private void _OnSwitchTab_b__9_0();
		[CompilerGenerated]
		private void _Start_b__11_0();
		[CompilerGenerated]
		private void _CheckStoneForWeaponExtension_b__20_0(ShopNormalShopPurchaseResponse res);
		[CompilerGenerated]
		private void _CheckStoneForDragonExtension_b__24_0(ShopNormalShopPurchaseResponse res);
		[CompilerGenerated]
		private void _CheckStoneForAmuletExtension_b__28_0(ShopNormalShopPurchaseResponse res);
	}
}
