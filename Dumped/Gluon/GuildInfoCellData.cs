using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class GuildInfoCellData
	{
		public enum PopulationType
		{
			Small,
			Medium,
			Large
		}

		public class FilterOption
		{
			public static readonly int[] maxApprovalFilterFlags;

			public static readonly int[] maxActivityFilterFlags;

			public static readonly int[] maxPopulationFilterFlags;

			public List<int> approvalFilterFlags;

			public List<int> activityFilterFlags;

			public List<int> populationFilterFlags;

			public bool IsAnyFilterOn()
			{
				return default(bool);
			}

			public void FillApprovalOption(GuildModel.GuildOption.GuildApprovalRequirement[] values)
			{
			}

			public void FillActivityOption(GuildModel.GuildOption.GuildActivityPreference[] values)
			{
			}

			public bool CheckPopulation(int population)
			{
				return default(bool);
			}

			public bool IsDataFit(GuildInfoCellData data)
			{
				return default(bool);
			}

			public bool CheckOption(List<int> flag, int value)
			{
				return default(bool);
			}
		}

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

		public GuildInfoCellData()
		{
		}

		public GuildInfoCellData(int guildId, int emblemId, string guildName, string guildMotto, bool isGuildNameDeleted, bool isGuildMottoDeleted, int population, GuildModel.GuildOption.GuildApprovalRequirement approvalRequirement, GuildModel.GuildOption.GuildActivityPreference activityPreference, GuildInviteReceiveList inviteReceiveList)
		{
		}

		public static List<GuildInfoCellData> ConvertGuildDataList(DataManager.GameData<GuildData> dataList)
		{
			return null;
		}

		public static List<GuildInfoCellData> ConvertGuildDataList(DataManager.GameData<GuildInviteReceiveList> dataList)
		{
			return null;
		}

		public static GuildInfoCellData ConvertGuildData(GuildData d)
		{
			return null;
		}

		public static GuildInfoCellData ConvertGuildData(GuildInviteReceiveList inviteReceiveData)
		{
			return null;
		}
	}
}
