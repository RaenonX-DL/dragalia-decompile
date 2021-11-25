using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class NormalShopElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _GoodsName;

		[SerializeField]
		private string _GoodsDescription;

		[SerializeField]
		private string _IconImage;

		[SerializeField]
		private int _ViewCategory;

		[SerializeField]
		private int _ServiceFlowType;

		[SerializeField]
		private int _LabelType;

		[SerializeField]
		private int _PackContentType;

		[SerializeField]
		private int _PackContentSubType;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _ResetType;

		[SerializeField]
		private int _Limit;

		[SerializeField]
		private QuestType _ReleaseQuestType;

		[SerializeField]
		private int _ReleaseQuestId;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		[SerializeField]
		private PaymentType _PaymentType;

		[SerializeField]
		private int _OptionValue;

		[SerializeField]
		private int _PaymentRelationId;

		[SerializeField]
		private int _NeedCost;

		[SerializeField]
		private GiftType _DestinationEntityType1;

		[SerializeField]
		private int _DestinationEntityId1;

		[SerializeField]
		private int _DestinationEntityQuantity1;

		[SerializeField]
		private int _DestinationLimitBreakCount1;

		[SerializeField]
		private GiftType _DestinationEntityType2;

		[SerializeField]
		private int _DestinationEntityId2;

		[SerializeField]
		private int _DestinationEntityQuantity2;

		[SerializeField]
		private int _DestinationLimitBreakCount2;

		[SerializeField]
		private GiftType _DestinationEntityType3;

		[SerializeField]
		private int _DestinationEntityId3;

		[SerializeField]
		private int _DestinationEntityQuantity3;

		[SerializeField]
		private int _DestinationLimitBreakCount3;

		[SerializeField]
		private GiftType _DestinationEntityType4;

		[SerializeField]
		private int _DestinationEntityId4;

		[SerializeField]
		private int _DestinationEntityQuantity4;

		[SerializeField]
		private int _DestinationLimitBreakCount4;

		[SerializeField]
		private GiftType _DestinationEntityType5;

		[SerializeField]
		private int _DestinationEntityId5;

		[SerializeField]
		private int _DestinationEntityQuantity5;

		[SerializeField]
		private int _DestinationLimitBreakCount5;

		[SerializeField]
		private GiftType _DestinationEntityType6;

		[SerializeField]
		private int _DestinationEntityId6;

		[SerializeField]
		private int _DestinationEntityQuantity6;

		[SerializeField]
		private int _DestinationLimitBreakCount6;

		[SerializeField]
		private GiftType _DestinationEntityType7;

		[SerializeField]
		private int _DestinationEntityId7;

		[SerializeField]
		private int _DestinationEntityQuantity7;

		[SerializeField]
		private int _DestinationLimitBreakCount7;

		[SerializeField]
		private GiftType _DestinationEntityType8;

		[SerializeField]
		private int _DestinationEntityId8;

		[SerializeField]
		private int _DestinationEntityQuantity8;

		[SerializeField]
		private int _DestinationLimitBreakCount8;

		[SerializeField]
		private int _BonusGoodsType;

		[SerializeField]
		private int _StaminaSingleCount;

		[SerializeField]
		private int _StaminaMultiCount;

		[SerializeField]
		private int _AddMaxDragonQuantity;

		[SerializeField]
		private int _AddMaxWeaponQuantity;

		[SerializeField]
		private int _AddMaxAmuletQuantity;

		public int Id => default(int);

		public string GoodsName => null;

		public string GoodsDescription => null;

		public string IconImage => null;

		public int ViewCategory => default(int);

		public int ServiceFlowType => default(int);

		public int LabelType => default(int);

		public int PackContentType => default(int);

		public int PackContentSubType => default(int);

		public int Priority => default(int);

		public int ResetType => default(int);

		public int Limit => default(int);

		public QuestType ReleaseQuestType => default(QuestType);

		public int ReleaseQuestId => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public PaymentType PaymentType => default(PaymentType);

		public int OptionValue => default(int);

		public int PaymentRelationId => default(int);

		public int NeedCost => default(int);

		public GiftType DestinationEntityType1 => default(GiftType);

		public int DestinationEntityId1 => default(int);

		public int DestinationEntityQuantity1 => default(int);

		public int DestinationLimitBreakCount1 => default(int);

		public GiftType DestinationEntityType2 => default(GiftType);

		public int DestinationEntityId2 => default(int);

		public int DestinationEntityQuantity2 => default(int);

		public int DestinationLimitBreakCount2 => default(int);

		public GiftType DestinationEntityType3 => default(GiftType);

		public int DestinationEntityId3 => default(int);

		public int DestinationEntityQuantity3 => default(int);

		public int DestinationLimitBreakCount3 => default(int);

		public GiftType DestinationEntityType4 => default(GiftType);

		public int DestinationEntityId4 => default(int);

		public int DestinationEntityQuantity4 => default(int);

		public int DestinationLimitBreakCount4 => default(int);

		public GiftType DestinationEntityType5 => default(GiftType);

		public int DestinationEntityId5 => default(int);

		public int DestinationEntityQuantity5 => default(int);

		public int DestinationLimitBreakCount5 => default(int);

		public GiftType DestinationEntityType6 => default(GiftType);

		public int DestinationEntityId6 => default(int);

		public int DestinationEntityQuantity6 => default(int);

		public int DestinationLimitBreakCount6 => default(int);

		public GiftType DestinationEntityType7 => default(GiftType);

		public int DestinationEntityId7 => default(int);

		public int DestinationEntityQuantity7 => default(int);

		public int DestinationLimitBreakCount7 => default(int);

		public GiftType DestinationEntityType8 => default(GiftType);

		public int DestinationEntityId8 => default(int);

		public int DestinationEntityQuantity8 => default(int);

		public int DestinationLimitBreakCount8 => default(int);

		public int BonusGoodsType => default(int);

		public int StaminaSingleCount => default(int);

		public int StaminaMultiCount => default(int);

		public int AddMaxDragonQuantity => default(int);

		public int AddMaxWeaponQuantity => default(int);

		public int AddMaxAmuletQuantity => default(int);
	}
}
