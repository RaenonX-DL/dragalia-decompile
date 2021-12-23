using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class Footer : MonoBehaviour
	{
		public enum MenuTab
		{
			None = -1,
			MyPage,
			Growth,
			Party,
			Fort,
			Summon,
			Menu,
			Event,
			VoidBattle,
			Quest,
			Drill,
			Max
		}

		public enum freeSummonIcon
		{
			FreeSummonOnceADay,
			ConsecutionCampaignSummon
		}

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

		public static int currentMenuTabForIndexing
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public static int MenuTabToIndex(MenuTab tab)
		{
			return default(int);
		}

		public static void SetNormalQuestMode()
		{
		}

		public static void SetSpecialEventMode()
		{
		}

		public static void SetVoidBattleMode()
		{
		}

		public static bool IsSpecialEventMode()
		{
			return default(bool);
		}

		public static bool IsVoidBattleMode()
		{
			return default(bool);
		}

		public static bool IsCurrentTabQuest()
		{
			return default(bool);
		}

		private static bool IsQuestTab(MenuTab tab)
		{
			return default(bool);
		}

		private static bool IsMyPageTab(MenuTab tab)
		{
			return default(bool);
		}

		public static ThemeColor GetCurrentThemeColor()
		{
			return default(ThemeColor);
		}

		public static ThemeColor GetThemeColorFromMenuTab(MenuTab menuTab)
		{
			return default(ThemeColor);
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void CheckFortBadge()
		{
		}

		public static void ResetOnTitle()
		{
		}

		public static void Reset()
		{
		}

		private bool CanResponds()
		{
			return default(bool);
		}

		private void RefreshPressedTime()
		{
		}

		public void OnMyPageButtonPressed()
		{
		}

		public void OnMyPageButtonLongPressed()
		{
		}

		public void OnQuestButtonPressed()
		{
		}

		public void OnGrowthButtonPressed()
		{
		}

		public void OnPartyButtonPressed()
		{
		}

		public void OnFortButtonPressed()
		{
		}

		public void OnFortButtonLongPressed()
		{
		}

		public void OnSummonButtonPressed()
		{
		}

		public void OnMenuButtonPressed()
		{
		}

		public void OnButtonPressed(string sceneName, MenuTab menuTab, bool isAddSceneClearInstantly = true, bool playSE = true)
		{
		}

		private void CleanupForTransition(MenuTab menuTab)
		{
		}

		public bool CanRespondWithButtonLongPressed(string sceneName, MenuTab menuTab)
		{
			return default(bool);
		}

		public void OnButtonLongPressed(string sceneName, MenuTab menuTab)
		{
		}

		public void OnButtonDown(MenuTab menuTab)
		{
		}

		public void OnButtonUp(MenuTab menuTab)
		{
		}

		public void ResetButtonDownStatus()
		{
		}

		private bool IsSameTab(MenuTab menuTab)
		{
			return default(bool);
		}

		public void SetActiveFooterMenu(MenuTab tab)
		{
		}

		public void SetActiveFooterMenuNormalQuestMode()
		{
		}

		public void SetActiveFooterMenuSpecialEventMode()
		{
		}

		public void SetActiveFooterMenuVoidBattleMode()
		{
		}

		public void SetActiveFooterMenuNormalMenuMode()
		{
		}

		public void ResetSelectedStatus()
		{
		}

		public void DisableOthersTemporary(MenuTab tab)
		{
		}

		public void SetFortBadge(bool isActive)
		{
		}

		public void SetMenuEnabled(MenuTab menuTab, bool enabled)
		{
		}

		public void SetAllMenuEnabled(bool enabled)
		{
		}

		public void SetAllMenuTouchable(bool enabled)
		{
		}

		public static void SyncAnimationWithBgm()
		{
		}

		public void UpdateSummonBanner()
		{
		}

		private void HideSummonBanner()
		{
		}

		private bool ShowSummonBanner(SummonDataElement data)
		{
			return default(bool);
		}

		private bool ShowSummonBanners(List<SummonDataElement> data)
		{
			return default(bool);
		}

		public void CheckMaintenance()
		{
		}

		public void CheckTutorial(bool isCheckOnTutorial = true)
		{
		}

		public void SetMenuEnabledTutorialFlag(MenuTab menuTab, bool enabled)
		{
		}

		public void SetAllMenuEnabledTutorialFlag(bool enabled)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void UpdateQuestBanner()
		{
		}

		public bool IsNewStoryMarkShow()
		{
			return default(bool);
		}

		public void ShowNewStoryMark(bool enable)
		{
		}

		private bool IsNewChapterMarkShow()
		{
			return default(bool);
		}

		private void ShowNewChapterMark(bool enable)
		{
		}

		public bool IsEnebledSelectFooter(MenuTab tabType)
		{
			return default(bool);
		}
	}
}
