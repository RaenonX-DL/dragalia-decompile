/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventRewardCellData
	{
		// Fields
		public int rewardId;
		public int eventItemId;
		public int eventItemQuantity;
		public GiftType rewardEntityType;
		public int rewardEntityId;
		public int rewardEntityQuantity;
		public int tier;
		public int rewardGetClearTime;
		public string rankingRewardDetailText;
		public string questNameStr;
		public QuestEventType questEventType;
		public bool isShowBadge;
		public bool hasGot;
	
		// Constructors
		public QuestEventRewardCellData(RankingTierRewardElement eventReward);
	}
}
