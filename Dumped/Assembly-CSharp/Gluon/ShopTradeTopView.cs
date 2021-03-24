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
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeTopView : ShopTradePanelBase
	{
		// Fields
		[Header]
		[SerializeField]
		public PageViewBase pageView;
		public GameObject pageViewNode;
		[Header]
		[SerializeField]
		public GameObject materialSummonBadge;
		public GameObject amuletNewIcon;
		public GameObject diaRecommendedIcon;
		[Header]
		[SerializeField]
		public GameObject campaignButtonGO;
		public ButtonWithSelectedImage campaignButtonWithSelectedImage;
		[Header]
		[SerializeField]
		public Image centerBannerBGImage;
		public MaintenanceButtonController centerBGMaintenanceButton;
		public UnityEngine.UI.Text centerBannerText;
		[Header]
		[SerializeField]
		public GameObject starterPackSubBanner;
		public GameObject commonPackSubBanner;
		private const float autoMoveTime = 8f;
		private float moveTimer;
		private bool autoMove;
		private GameObject preLoadedPage;
		private ShopTopBannerModel.BannerData centerData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public Action onHttpDoneCallback;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _RequestForEntryHttp_b__0(ShopGetListResponse res);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__19_0;
			public static Action<ShopTradePanelBase> __9__22_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__19_0();
			internal void _OnCenterBannerPressed_b__22_1(ShopTradePanelBase panel);
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShopTradeTopView __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public List<ShopTopBannerModel.BannerData> finalList;
			public ShopTradeTopView __4__this;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _GenerateCenterBanners_b__0(GameObject go, int index);
			internal void _GenerateCenterBanners_b__1(int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public ShopTradeTopView __4__this;
			public CampaignListPopup popup;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _OnCampainButtonPressed_b__0();
			internal void _OnCampainButtonPressed_b__1();
		}
	
		// Constructors
		public ShopTradeTopView();
	
		// Methods
		public static ShopTradeTopView Create(Transform parent, ShopTradeScene scene);
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		[IteratorStateMachine]
		private IEnumerator Start();
		private void SetSubBanner();
		private void SetCenterBannerBG(ShopTopBannerModel.BannerData data);
		public void OnCenterBannerPressed();
		private void GenerateCenterBanners();
		private void Update();
		public void CheckAmuletNewBadge();
		public void CheckDiaRecommendedBadge();
		public void OnCampainButtonPressed();
		[CompilerGenerated]
		private void _OnCenterBannerPressed_b__22_0(ShopTradePanelBase panel);
	}
}
