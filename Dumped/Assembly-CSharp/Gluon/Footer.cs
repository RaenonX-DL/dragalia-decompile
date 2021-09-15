/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Footer : MonoBehaviour
	{
		// Fields
		public static int selectedIndex;
		public FooterIcon[] footerIcons;
		public static MenuTab currentMenuTab;
		private bool[] menuEnabled;
		private bool[] menuEnabledTutorial;
		private bool[] menuEnabledMaintenance;
		public UnityAction<string, MenuTab> onFooterButtonPressed;
		public UnityAction<string, MenuTab> onFooterButtonLongPressed;
		[SerializeField]
		private GameObject fortBadge;
		[SerializeField]
		private GameObject untouchableLayer;
		[SerializeField]
		private Button[] menuButtons;
		[SerializeField]
		private GameObject newStoryMark;
		[SerializeField]
		private GameObject newChapterMark;
		private float prevPressedTime;
		private Material changeableMaterial;
		private Material disabledMaterial;
		private Material selectedMaterial;
		private Material selectedTextMaterial;
	
		// Properties
		public static int currentMenuTabForIndexing { get; private set; }
	
		// Nested types
		public enum MenuTab
		{
			None = -1,
			MyPage = 0,
			Growth = 1,
			Party = 2,
			Fort = 3,
			Summon = 4,
			Menu = 5,
			Event = 6,
			VoidBattle = 7,
			Quest = 8,
			Drill = 9,
			Max = 10
		}
	
		public enum freeSummonIcon
		{
			FreeSummonOnceADay = 0,
			ConsecutionCampaignSummon = 1
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Footer __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__54_0;
			public static Func<SummonDataElement, bool> __9__70_1;
			public static Func<SummonDataElement, bool> __9__70_2;
			public static Func<SummonDataElement, int> __9__70_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnButtonLongPressed_b__54_0();
			internal bool _UpdateSummonBanner_b__70_1(SummonDataElement x);
			internal bool _UpdateSummonBanner_b__70_2(SummonDataElement x);
			internal int _UpdateSummonBanner_b__70_0(SummonDataElement x);
		}
	
		// Constructors
		public Footer();
		static Footer();
	
		// Methods
		public static int MenuTabToIndex(MenuTab tab);
		public static void SetNormalQuestMode();
		public static void SetSpecialEventMode();
		public static void SetVoidBattleMode();
		public static bool IsSpecialEventMode();
		public static bool IsVoidBattleMode();
		public static bool IsCurrentTabQuest();
		private static bool IsQuestTab(MenuTab tab);
		private static bool IsMyPageTab(MenuTab tab);
		public static ThemeColor GetCurrentThemeColor();
		public static ThemeColor GetThemeColorFromMenuTab(MenuTab menuTab);
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void CheckFortBadge();
		public static void ResetOnTitle();
		public static void Reset();
		private bool CanResponds();
		private void RefreshPressedTime();
		public void OnMyPageButtonPressed();
		public void OnMyPageButtonLongPressed();
		public void OnQuestButtonPressed();
		public void OnGrowthButtonPressed();
		public void OnPartyButtonPressed();
		public void OnFortButtonPressed();
		public void OnFortButtonLongPressed();
		public void OnSummonButtonPressed();
		public void OnMenuButtonPressed();
		public void OnButtonPressed(string sceneName, MenuTab menuTab, bool isAddSceneClearInstantly = true, bool playSE = true);
		private void CleanupForTransition(MenuTab menuTab);
		public bool CanRespondWithButtonLongPressed(string sceneName, MenuTab menuTab);
		public void OnButtonLongPressed(string sceneName, MenuTab menuTab);
		public void OnButtonDown(MenuTab menuTab);
		public void OnButtonUp(MenuTab menuTab);
		public void ResetButtonDownStatus();
		private bool IsSameTab(MenuTab menuTab);
		public void SetActiveFooterMenu(MenuTab tab);
		public void SetActiveFooterMenuNormalQuestMode();
		public void SetActiveFooterMenuSpecialEventMode();
		public void SetActiveFooterMenuVoidBattleMode();
		public void ResetSelectedStatus();
		public void DisableOthersTemporary(MenuTab tab);
		public void SetFortBadge(bool isActive);
		public void SetMenuEnabled(MenuTab menuTab, bool enabled);
		public void SetAllMenuEnabled(bool enabled);
		public void SetAllMenuTouchable(bool enabled);
		public static void SyncAnimationWithBgm();
		public void UpdateSummonBanner();
		private void HideSummonBanner();
		private bool ShowSummonBanner(SummonDataElement data);
		private bool ShowSummonBanners(List<SummonDataElement> data);
		public void CheckMaintenance();
		public void CheckTutorial(bool isCheckOnTutorial = true);
		public void SetMenuEnabledTutorialFlag(MenuTab menuTab, bool enabled);
		public void SetAllMenuEnabledTutorialFlag(bool enabled);
		private void OnApplicationPause(bool pause);
		public void UpdateQuestBanner();
		public bool IsNewStoryMarkShow();
		public void ShowNewStoryMark(bool enable);
		private bool IsNewChapterMarkShow();
		private void ShowNewChapterMark(bool enable);
		public bool IsEnebledSelectFooter(MenuTab tabType);
		[CompilerGenerated]
		private void _Start_b__36_0(PartyIndexResponse res);
	}
}
