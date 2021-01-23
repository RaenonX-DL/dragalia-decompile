/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRewardCellData
	{
		// Fields
		public int rewardId;
		public int eventItemId;
		public int eventItemQuantity;
		public GiftType rewardEntityType;
		public int rewardEntityId;
		public int rewardEntityQuantity;
		public bool isShowBadge;
		public bool hasGot;
		public int eventId;
		public int cycleId;
		public int cyclePoint;
	
		// Constructors
		public EventRewardCellData(RaidEventRewardElement eventReward);
		public EventRewardCellData(MazeEventRewardElement eventReward);
		public EventRewardCellData(BuildEventRewardElement eventReward);
		public EventRewardCellData(EventCyclePointRewardElement eventReward, int eventId, int cycleId, int cyclePoint);
	}
}
