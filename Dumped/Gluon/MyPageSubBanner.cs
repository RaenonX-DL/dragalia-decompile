using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPageSubBanner : MonoBehaviour
	{
		public enum BannerType
		{
			PanelMission = 1,
			WelcomePack,
			PeriodLimitSingle,
			EventNotice,
			EventQuestInfo,
			StartDashMission,
			PlatinumRegendSummon,
			PeriodLimitMultiple,
			AstralRaidQuestInfo,
			SeasonVoice,
			Shooting,
			CurrentSummon,
			LotteryLetter
		}

		public enum EventState
		{
			None,
			Before,
			Open,
			After
		}

		public class BannerInfo
		{
			public EventState eventState;

			public string path;

			public BannerInfo(string path)
			{
			}

			public BannerInfo(string path, EventState eventState)
			{
			}
		}

		public static int daysOfStartDashMission;

		public MyPageSubBannerController controller;

		public Image mainImage;

		public bool isLoadCompleted;

		public MyPageBannerElement element;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private CircleOutline outline;

		private Material mainMaterial;

		[HideInInspector]
		public MyPageScene scene;

		private readonly Color normalTextColor;

		private readonly Color normalOutlineColor;

		private readonly Color eventTextColor;

		private readonly Color eventOutlineColor;

		public BannerInfo info
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static BannerInfo GetValidBannerInfo(MyPageBannerElement element)
		{
			return null;
		}

		public void Init(BannerInfo info, MyPageBannerElement element)
		{
		}

		private void OnDestroy()
		{
		}

		private void LoadBannerAsset(string path)
		{
		}

		private static BannerInfo InitStartDashMission(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitPeriodLimitSinglePack(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitWelcomePack(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitEventNotice(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitEventQuest(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitPlatinumRegendSummon(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitCurrentSummon(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitPeriodLimitMultiple(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitSeasonVoice(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitOther(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitOtherShooting(MyPageBannerElement element)
		{
			return null;
		}

		private static BannerInfo InitLotteryLetter(MyPageBannerElement element)
		{
			return null;
		}

		public void OnPressed()
		{
		}

		public string GetTitle()
		{
			return null;
		}

		private void OpenWebViewInfo()
		{
		}

		private void GoToPeriodLimitSinglePack()
		{
		}

		private void GoToWelcomePack()
		{
		}

		private void GoToPeriodLimitMultipleShop()
		{
		}

		private void ShowNextEventPreviewPopup(int eventId)
		{
		}

		private void GoToSummon()
		{
		}

		private void GoToShooting()
		{
		}

		private void LoadSceneQuestMenu(int questGroupId)
		{
		}

		private void GoEventQuest(int questEventId)
		{
		}

		private void GoToLotteryLetter(int eventId)
		{
		}

		public void SetEnabled(bool enabled)
		{
		}

		private void SetTitleText(string str)
		{
		}

		private void SetTextColor(int bannerType)
		{
		}

		public static bool IsBetweenStartAndEndDate(string startDate, string endDate)
		{
			return default(bool);
		}

		private void ApplyLoadedTexture(Material bannerAsset, Material maskAsset)
		{
		}

		public void SetLoadBanner(string str)
		{
		}
	}
}
