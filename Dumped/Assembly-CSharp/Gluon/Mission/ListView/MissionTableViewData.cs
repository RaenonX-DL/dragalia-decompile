/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Mission;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission.ListView
{
	public class MissionTableViewData
	{
		// Fields
		public int sortId;
		public Category category;
		public int missionId;
		public Gluon.Mission.Type type;
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
	
		// Nested types
		public enum Category
		{
			None = -1,
			Daily = 0,
			Period = 1,
			Normal = 2,
			Beginner = 3,
			Special = 4,
			Drill = 5,
			DrillComplete = 6
		}
	
		public enum State
		{
			NotClear = 0,
			Cleared = 1,
			Received = 2
		}
	
		public enum CellType
		{
			Mission = 0,
			Caption = 1,
			Text = 2
		}
	
		// Constructors
		public MissionTableViewData();
	}
}
