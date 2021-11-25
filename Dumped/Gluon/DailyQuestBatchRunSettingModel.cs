using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class DailyQuestBatchRunSettingModel
	{
		private static DailyQuestBatchRunSettingModel instance;

		public static DailyQuestBatchRunSettingModel Instance => null;

		public static bool HasInstance => default(bool);

		public List<int> TargetQuestList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private DailyQuestBatchRunSettingModel()
		{
		}

		public void AddTargetQuest(int questId)
		{
		}

		public void Clear()
		{
		}

		public bool IsDailyQuestBatchRun()
		{
			return default(bool);
		}

		public static List<int> GetDailyQuestEventIdList()
		{
			return null;
		}
	}
}
