/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CampaignUtil : MonoBehaviour
	{
		// Fields
		private const int beginnerBuildTimeDate = 30;
		private static Dictionary<int, List<CampaignDataElement>> questGroupDropUpCampaignsDictionary;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public DateTime currentTime;
			public DayOfWeek dayOfWeek;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal bool _IsWithInItemDropUpCampaign_b__0(QuestScheduleDataWrapper e);
		}
	
		// Constructors
		public CampaignUtil();
		static CampaignUtil();
	
		// Methods
		public static bool IsWithInStaminaAndDropRateCampaign();
		public static bool IsWithInManaUpCampaign();
		public static bool IsWithInCoinUpCampaign();
		public static bool IsWithInItemDropUpCampaign(QuestSupportCanvas.PlayType playType);
		public static bool IsWithInLoginBonusSkipTicketCampaign();
		public static CampaignDataElement GetLoginBonusSkipTicketCampaign();
		public static string GenerateCampaignEndTimeString(CampaignDataElement data);
		public static string GenerateCampaignEndTimeString(string campaignEndDate);
		public static CampaignDataElement GetWithInManaUpCampaignDataElement(int groupId);
		public static CampaignDataElement GetWithInCoinUpCampaignDataElement(int groupId);
		public static CampaignDataElement GetWithInItemDropUpCampaignDataElement(int groupId);
		public static void ClearCache();
		public static CampaignDataElement GetWithInItemSummonAllFreeCampaignDataElement();
		public static bool IsBeginnerBuildTime();
		public static DateTime GetBeginnerBuildTimeStartTime();
		public static DateTime GetBeginnerBuildTimeEndTime();
	}
}
