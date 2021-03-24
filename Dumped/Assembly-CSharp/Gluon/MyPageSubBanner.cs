/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageSubBanner : MonoBehaviour
	{
		// Fields
		public static int daysOfStartDashMission;
		public MyPageSubBannerController controller;
		public Image mainImage;
		public bool isLoadCompleted;
		public MyPageBannerElement element;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private CircleOutline outline;
		private Material mainMaterial;
		[CompilerGenerated]
		private BannerInfo _info_k__BackingField;
		[HideInInspector]
		public MyPageScene scene;
		private readonly Color normalTextColor;
		private readonly Color normalOutlineColor;
		private readonly Color eventTextColor;
		private readonly Color eventOutlineColor;
	
		// Properties
		public BannerInfo info { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum BannerType
		{
			PanelMission = 1,
			WelcomePack = 2,
			PeriodLimitSingle = 3,
			EventNotice = 4,
			EventQuestInfo = 5,
			StartDashMission = 6,
			PlatinumRegendSummon = 7,
			PeriodLimitMultiple = 8,
			AstralRaidQuestInfo = 9,
			SeasonVoice = 10,
			Shooting = 11,
			CurrentSummon = 12,
			LotteryLetter = 13
		}
	
		public enum EventState
		{
			None = 0,
			Before = 1,
			Open = 2,
			After = 3
		}
	
		public class BannerInfo
		{
			// Fields
			public EventState eventState;
			public string path;
	
			// Constructors
			public BannerInfo(string path);
			public BannerInfo(string path, EventState eventState);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public Material bannerAsset;
			public MyPageSubBanner __4__this;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _Init_b__1(Material maskAsset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public Material bannerAsset;
			public MyPageSubBanner __4__this;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _LoadBannerAsset_b__1(Material maskAsset);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__36_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnPressed_b__36_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public EventNextPreviewPopup popup;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _ShowNextEventPreviewPopup_b__0();
		}
	
		// Constructors
		public MyPageSubBanner();
		static MyPageSubBanner();
	
		// Methods
		public static BannerInfo GetValidBannerInfo(MyPageBannerElement element);
		public void Init(BannerInfo info, MyPageBannerElement element);
		private void OnDestroy();
		private void LoadBannerAsset(string path);
		private static BannerInfo InitStartDashMission(MyPageBannerElement element);
		private static BannerInfo InitPeriodLimitSinglePack(MyPageBannerElement element);
		private static BannerInfo InitWelcomePack(MyPageBannerElement element);
		private static BannerInfo InitEventNotice(MyPageBannerElement element);
		private static BannerInfo InitEventQuest(MyPageBannerElement element);
		private static BannerInfo InitPlatinumRegendSummon(MyPageBannerElement element);
		private static BannerInfo InitCurrentSummon(MyPageBannerElement element);
		private static BannerInfo InitPeriodLimitMultiple(MyPageBannerElement element);
		private static BannerInfo InitSeasonVoice(MyPageBannerElement element);
		private static BannerInfo InitOther(MyPageBannerElement element);
		private static BannerInfo InitOtherShooting(MyPageBannerElement element);
		private static BannerInfo InitLotteryLetter(MyPageBannerElement element);
		public void OnPressed();
		public string GetTitle();
		private void OpenWebViewInfo();
		private void GoToPeriodLimitSinglePack();
		private void GoToWelcomePack();
		private void GoToPeriodLimitMultipleShop();
		private void ShowNextEventPreviewPopup(int eventId);
		private void GoToSummon();
		private void GoToShooting();
		private void LoadSceneQuestMenu(int questGroupId);
		private void GoEventQuest(int questEventId);
		private void GoToLotteryLetter(int eventId);
		public void SetEnabled(bool enabled);
		private void SetTitleText(string str);
		private void SetTextColor(int bannerType);
		public static bool IsBetweenStartAndEndDate(string startDate, string endDate);
		private void ApplyLoadedTexture(Material bannerAsset, Material maskAsset);
		public void SetLoadBanner(string str);
		[CompilerGenerated]
		private void _Init_b__21_0(Material bannerAsset);
		[CompilerGenerated]
		private void _LoadBannerAsset_b__23_0(Material bannerAsset);
		[CompilerGenerated]
		private void _OnPressed_b__36_0();
		[CompilerGenerated]
		private void _OnPressed_b__36_2();
		[CompilerGenerated]
		private void _OnPressed_b__36_3();
	}
}
