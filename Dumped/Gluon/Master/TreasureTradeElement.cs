using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TreasureTradeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TradeGroupId;

		[SerializeField]
		private string _NoticeText;

		[SerializeField]
		private int _TabGroupId;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _ResetType;

		[SerializeField]
		private int _Limit;

		[SerializeField]
		private int _TreasureGroupId;

		[SerializeField]
		private int _TreasureGroupNo;

		[SerializeField]
		private int _ClearQuestStoryId;

		[SerializeField]
		private int _NeedLimitBreakAbilityCrestId;

		[SerializeField]
		private int _IsLockView;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		[SerializeField]
		private GiftType _NeedEntityType1;

		[SerializeField]
		private int _NeedEntityId1;

		[SerializeField]
		private int _NeedEntityQuantity1;

		[SerializeField]
		private int _NeedLimitBreakCount1;

		[SerializeField]
		private GiftType _NeedEntityType2;

		[SerializeField]
		private int _NeedEntityId2;

		[SerializeField]
		private int _NeedEntityQuantity2;

		[SerializeField]
		private int _NeedLimitBreakCount2;

		[SerializeField]
		private GiftType _NeedEntityType3;

		[SerializeField]
		private int _NeedEntityId3;

		[SerializeField]
		private int _NeedEntityQuantity3;

		[SerializeField]
		private int _NeedLimitBreakCount3;

		[SerializeField]
		private GiftType _NeedEntityType4;

		[SerializeField]
		private int _NeedEntityId4;

		[SerializeField]
		private int _NeedEntityQuantity4;

		[SerializeField]
		private int _NeedLimitBreakCount4;

		[SerializeField]
		private GiftType _NeedEntityType5;

		[SerializeField]
		private int _NeedEntityId5;

		[SerializeField]
		private int _NeedEntityQuantity5;

		[SerializeField]
		private int _NeedLimitBreakCount5;

		[SerializeField]
		private GiftType _DestinationEntityType;

		[SerializeField]
		private int _DestinationEntityId;

		[SerializeField]
		private int _DestinationEntityQuantity;

		[SerializeField]
		private int _DestinationLimitBreakCount;

		public int Id => default(int);

		public int TradeGroupId => default(int);

		public string NoticeText => null;

		public int TabGroupId => default(int);

		public int Priority => default(int);

		public int ResetType => default(int);

		public int Limit => default(int);

		public int TreasureGroupId => default(int);

		public int TreasureGroupNo => default(int);

		public int ClearQuestStoryId => default(int);

		public int NeedLimitBreakAbilityCrestId => default(int);

		public int IsLockView => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public GiftType NeedEntityType1 => default(GiftType);

		public int NeedEntityId1 => default(int);

		public int NeedEntityQuantity1 => default(int);

		public int NeedLimitBreakCount1 => default(int);

		public GiftType NeedEntityType2 => default(GiftType);

		public int NeedEntityId2 => default(int);

		public int NeedEntityQuantity2 => default(int);

		public int NeedLimitBreakCount2 => default(int);

		public GiftType NeedEntityType3 => default(GiftType);

		public int NeedEntityId3 => default(int);

		public int NeedEntityQuantity3 => default(int);

		public int NeedLimitBreakCount3 => default(int);

		public GiftType NeedEntityType4 => default(GiftType);

		public int NeedEntityId4 => default(int);

		public int NeedEntityQuantity4 => default(int);

		public int NeedLimitBreakCount4 => default(int);

		public GiftType NeedEntityType5 => default(GiftType);

		public int NeedEntityId5 => default(int);

		public int NeedEntityQuantity5 => default(int);

		public int NeedLimitBreakCount5 => default(int);

		public GiftType DestinationEntityType => default(GiftType);

		public int DestinationEntityId => default(int);

		public int DestinationEntityQuantity => default(int);

		public int DestinationLimitBreakCount => default(int);
	}
}
