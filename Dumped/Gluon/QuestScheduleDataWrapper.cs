using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;

namespace Gluon
{
	public class QuestScheduleDataWrapper
	{
		private int campaignPercent;

		public int QuestId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime StartDate
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime EndDate
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int IntervalType
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsGeneratedByLegacyData
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static List<QuestScheduleDataWrapper> Convert(QuestScheduleDetailList questScheduleDetail)
		{
			return null;
		}

		public QuestScheduleDataWrapper(int questId, QuestScheduleDetailList questScheduleDetail)
		{
		}

		public int GetDropUpCampaignPercent()
		{
			return default(int);
		}
	}
}
