using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CampaignUtil : MonoBehaviour
	{
		private const int beginnerBuildTimeDate = 30;

		private static Dictionary<int, List<CampaignDataElement>> questGroupDropUpCampaignsDictionary;

		public static bool IsWithInStaminaAndDropRateCampaign()
		{
			return default(bool);
		}

		public static bool IsWithInManaUpCampaign()
		{
			return default(bool);
		}

		public static bool IsWithInCoinUpCampaign()
		{
			return default(bool);
		}

		public static bool IsWithInItemDropUpCampaign(QuestSupportCanvas.PlayType playType)
		{
			return default(bool);
		}

		public static bool IsWithInLoginBonusSkipTicketCampaign()
		{
			return default(bool);
		}

		public static CampaignDataElement GetLoginBonusSkipTicketCampaign()
		{
			return null;
		}

		public static string GenerateCampaignEndTimeString(CampaignDataElement data)
		{
			return null;
		}

		public static string GenerateCampaignEndTimeString(string campaignEndDate)
		{
			return null;
		}

		public static CampaignDataElement GetWithInManaUpCampaignDataElement(int groupId)
		{
			return null;
		}

		public static CampaignDataElement GetWithInCoinUpCampaignDataElement(int groupId)
		{
			return null;
		}

		public static CampaignDataElement GetWithInItemDropUpCampaignDataElement(int groupId)
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		public static CampaignDataElement GetWithInItemSummonAllFreeCampaignDataElement()
		{
			return null;
		}

		public static bool IsBeginnerBuildTime()
		{
			return default(bool);
		}

		public static DateTime GetBeginnerBuildTimeStartTime()
		{
			return default(DateTime);
		}

		public static DateTime GetBeginnerBuildTimeEndTime()
		{
			return default(DateTime);
		}
	}
}
