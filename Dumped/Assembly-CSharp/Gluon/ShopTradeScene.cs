/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using NPF;
using NPF.NPFWrapper;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeScene : SceneBase
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform currentPanelNode;
		[SerializeField]
		private Transform nextPanelNode;
		[SerializeField]
		private Transform commonPanelNode;
		[SerializeField]
		private Transform tempPanelNode;
		[Header]
		[SerializeField]
		private GameObject httpGreenLight;
		public Camera mainUICamera;
		public Camera flashCamera;
		[HideInInspector]
		public Canvas canvas;
		private bool bPrevPanelExitDone;
		private bool bNextHttpReady;
		private ShopTradePanelBase activePanel;
		private Coroutine waitReadyStateCoroutine;
		private ShopCommonPage commonPage;
		public bool isTutorialRequired;
		private bool stopNextTopHttpRequestForInit;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public bool isExistTutorialUI;
			public ShopTradeScene __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _Start_b__1();
			internal bool _Start_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__18_0;
			public static Action<NPFErrorParam> __9__20_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__18_0();
			internal void _OnInitReady_b__20_2(NPFErrorParam error);
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShopTradeScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForReadyState_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShopTradeScene __4__this;
			public ShopTradeModel.PanelType type;
			public Action<ShopTradePanelBase> onNewPanelLoaded;
			public int scrollToItem;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForReadyState_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ShopTutorialCoroutine_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShopTradeScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShopTutorialCoroutine_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShopTradeScene();
	
		// Methods
		public ShopTradePanelBase GetActivePanel();
		public ShopCommonPage GetCommonPage();
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void LoadBG();
		private void LoadCommonPage();
		private void OnEnterScene();
		public override void StartExitAnimation();
		public void SwitchToPanel(ShopTradeModel.PanelType type, int scrollToItem = 0, Action<ShopTradePanelBase> onNewPanelLoaded = null);
		[IteratorStateMachine]
		private IEnumerator WaitForReadyState(ShopTradeModel.PanelType type, int scrollToItem = 0, Action<ShopTradePanelBase> onNewPanelLoaded = null);
		private void ReleasePanel(ShopTradeModel.PanelType type);
		private void RequestHttpForPanel(ShopTradeModel.PanelType type);
		public void LoadPanel(ShopTradeModel.PanelType type);
		public void SetNextHttpReady();
		private void OnDestroy();
		public override void OnPresentReceived();
		public override void OnItemUsed();
		private void ShopTutorial();
		[IteratorStateMachine]
		private IEnumerator ShopTutorialCoroutine();
		public void RefreshCommonPage();
		public static void GoToShopScene(ShopTradeModel.PanelType panel, ShopTradeProductData.CommonShopItemData.PackContentType scrollToItemType = ShopTradeProductData.CommonShopItemData.PackContentType.None, int scrollToItem = 0, ShopTradeProductData.CommonShopItemData.SpecialShopCategory specialShopCategory = ShopTradeProductData.CommonShopItemData.SpecialShopCategory.None);
		[CompilerGenerated]
		private void _OnInitReady_b__20_0(ShopGetListResponse res);
		[CompilerGenerated]
		private void _OnInitReady_b__20_1(List<NPFPayment.ProductInfo> infoList);
		[CompilerGenerated]
		private bool _WaitForReadyState_b__26_0();
		[CompilerGenerated]
		private bool _WaitForReadyState_b__26_1();
		[CompilerGenerated]
		private void _ReleasePanel_b__27_0();
		[CompilerGenerated]
		private void _ShopTutorialCoroutine_b__35_0();
		[CompilerGenerated]
		private void _ShopTutorialCoroutine_b__35_1();
	}
}
