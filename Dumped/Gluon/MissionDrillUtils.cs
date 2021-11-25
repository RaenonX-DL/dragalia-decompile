using System;
using Gluon.Master;

namespace Gluon
{
	public static class MissionDrillUtils
	{
		public static bool IsMissionDrillOpened()
		{
			return default(bool);
		}

		public static void RequestGetDrillMissionList(Action successCallback)
		{
		}

		private static void RequestUnlockFirstMissionGroup(Action successCallback)
		{
		}

		public static void GoToMissionDrillScene()
		{
		}

		public static MissionDrillGroupElement GetCurrentMissionDrillGroup()
		{
			return null;
		}

		public static MissionDrillGroupElement GetNextMissionDrillGroup()
		{
			return null;
		}

		public static bool IsAllClearedCurrentMission()
		{
			return default(bool);
		}

		public static bool IsAllClearedMissionGroup(int groupId)
		{
			return default(bool);
		}

		public static bool IsReceivedCompleteReward(int groupId)
		{
			return default(bool);
		}

		public static DrillTalkElement GetCurrentCompleteTalk()
		{
			return null;
		}

		public static DrillTalkElement GetCurrentNextTalk()
		{
			return null;
		}

		public static DrillTalkElement GetCommonDrillTalk()
		{
			return null;
		}

		public static DrillTalkElement GetReceivableMissionDrillTalk()
		{
			return null;
		}

		public static MissionDrillDataElement GetFirstMissionDrillData(int groupId)
		{
			return null;
		}

		public static MissionDrillDataElement GetPrevMissionDrillData(int missionId)
		{
			return null;
		}
	}
}
