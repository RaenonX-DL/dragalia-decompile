/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildInfoCellData
	{
		// Fields
		public int guildId;
		public int emblemId;
		public string guildName;
		public string guildMotto;
		public bool isGuildNameDeleted;
		public bool isGuildMottoDeleted;
		public int population;
		public GuildModel.GuildOption.GuildApprovalRequirement approvalRequirement;
		public GuildModel.GuildOption.GuildActivityPreference activityPreference;
		public GuildInviteReceiveList inviteReceiveList;
		public const int smallPopulationUpperBound = 10;
		public const int mediumPopulationUpperBound = 20;
	
		// Nested types
		public enum PopulationType
		{
			Small = 0,
			Medium = 1,
			Large = 2
		}
	
		public class FilterOption
		{
			// Fields
			public static readonly int[] maxApprovalFilterFlags;
			public static readonly int[] maxActivityFilterFlags;
			public static readonly int[] maxPopulationFilterFlags;
			public List<int> approvalFilterFlags;
			public List<int> activityFilterFlags;
			public List<int> populationFilterFlags;
	
			// Constructors
			public FilterOption();
			static FilterOption();
	
			// Methods
			public bool IsAnyFilterOn();
			public void FillApprovalOption(GuildModel.GuildOption.GuildApprovalRequirement[] values);
			public void FillActivityOption(GuildModel.GuildOption.GuildActivityPreference[] values);
			public bool CheckPopulation(int population);
			public bool IsDataFit(GuildInfoCellData data);
			public bool CheckOption(List<int> flag, int value);
		}
	
		// Constructors
		public GuildInfoCellData();
		public GuildInfoCellData(int guildId, int emblemId, string guildName, string guildMotto, bool isGuildNameDeleted, bool isGuildMottoDeleted, int population, GuildModel.GuildOption.GuildApprovalRequirement approvalRequirement, GuildModel.GuildOption.GuildActivityPreference activityPreference, GuildInviteReceiveList inviteReceiveList);
	
		// Methods
		public static List<GuildInfoCellData> ConvertGuildDataList(DataManager.GameData<GuildData> dataList);
		public static List<GuildInfoCellData> ConvertGuildDataList(DataManager.GameData<GuildInviteReceiveList> dataList);
		public static GuildInfoCellData ConvertGuildData(GuildData d);
		public static GuildInfoCellData ConvertGuildData(GuildInviteReceiveList inviteReceiveData);
	}
}
