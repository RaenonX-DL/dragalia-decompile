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
	public class SummonTopItemData
	{
		// Fields
		public bool hasCoverView;
		public int summonId;
		public int summonGroupId;
		public int summonPoint;
		public SummonType summonType;
		public int dailyPrice;
		public int singlePrice;
		public int multiPrice;
		public int haveExchangeSummonPoint;
		public int nessearyExchangeSummonPoint;
		public bool isExchangeSummon;
		public int addSummonPoint;
		public int addSummonPointStone;
		public bool isCSSummon;
		public int startTime;
		public int endTime;
		public bool bDailyDrawn;
		public bool bReachLimit;
		public int remainDrawableCount;
		public CampaignType campaignType;
		public int freeCountRest;
		public bool isBeginnerCampaign;
		public int beginnerCampaginCountRest;
		public List<PickupInfo> pickupInfo;
	
		// Nested types
		public enum ButtonType
		{
			None = 0,
			Daily = 1,
			SingleStoneOrTicket = 2,
			MultiStoneOrTicket = 3,
			SingleTicket = 4,
			MultiTicket = 5,
			StarLegend = 6,
			SingleStone = 7,
			MultiStone = 8,
			CharaSsrTicket = 9,
			Platinum = 10,
			DragonSsrTicket = 11,
			FreeMulti = 12,
			BeginnerFreeMulti = 13,
			Tutorial = 14
		}
	
		public class PickupInfo
		{
			// Fields
			public int masterOrderIndex;
			public int resourceIndex;
			public int id;
			public GiftType giftType;
	
			// Constructors
			public PickupInfo();
			public PickupInfo(int masterOrderIndex, int resourceIndex, int unitType, int id);
	
			// Methods
			private GiftType UnitTypeToGiftType(int unitType);
		}
	
		// Constructors
		public SummonTopItemData();
	
		// Methods
		public void UpdateDataFromResponse(SummonList atgenSummonList);
		public int GetCurrentPlatinumIndex();
	}
}
