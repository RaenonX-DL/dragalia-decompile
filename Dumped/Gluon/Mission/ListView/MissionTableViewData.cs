using System;
using UnityEngine.Events;

namespace Gluon.Mission.ListView
{
	public class MissionTableViewData
	{
		public enum Category
		{
			None = -1,
			Daily,
			Period,
			Normal,
			Beginner,
			Special,
			Drill,
			DrillComplete
		}

		public enum State
		{
			NotClear,
			Cleared,
			Received
		}

		public enum CellType
		{
			Mission,
			Caption,
			Text
		}

		public int sortId;

		public Category category;

		public int missionId;

		public Type type;

		public Dependency dependency;

		public string name;

		public Reward reward;

		public Achievement achievement;

		public Session session;

		public State state;

		public int dayNo;

		public int questGroupId;

		public int groupSortId;

		public CellType cellType;

		public UnityAction reloadCallback;

		public bool isLockMission;

		public bool isShowBadge;

		public MissionLockRewardType rewardType;

		public int rewardParam;

		public DateTime rewardUnlockTime;

		public MissionTransportType transportType;

		public int missionTransportValue;

		public string lockTitleText;

		public string lockInfoText;
	}
}
