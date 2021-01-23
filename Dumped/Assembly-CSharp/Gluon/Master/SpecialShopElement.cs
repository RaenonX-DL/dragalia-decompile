/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class SpecialShopElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _GoodsName;
		[SerializeField]
		private string _GoodsDescription;
		[SerializeField]
		private string _IconImage;
		[SerializeField]
		private int _GoodsCategory;
		[SerializeField]
		private int _ServiceFlowType;
		[SerializeField]
		private int _LabelType;
		[SerializeField]
		private int _IsPickupDiamondGroup;
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
		private int _LimitViewType;
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
		private int _ViewPlatform;
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
		private int _BonusGoodsQuantity;
		[SerializeField]
		private int _MissionPackGroupId;
		[SerializeField]
		private int _AddMaxDragonQuantity;
		[SerializeField]
		private int _AddMaxWeaponQuantity;
		[SerializeField]
		private int _AddMaxAmuletQuantity;
		[SerializeField]
		private int _AddStaminaSingle;
		[SerializeField]
		private int _AddStaminaMulti;
		[SerializeField]
		private int _GoodsType;
		[SerializeField]
		private int _TargetSummonId;
		[SerializeField]
		private string _DetailIcon1;
		[SerializeField]
		private string _DetailName1;
		[SerializeField]
		private string _DetailDescription1;
		[SerializeField]
		private string _DetailIcon2;
		[SerializeField]
		private string _DetailName2;
		[SerializeField]
		private string _DetailDescription2;
		[SerializeField]
		private string _DetailIcon3;
		[SerializeField]
		private string _DetailName3;
		[SerializeField]
		private string _DetailDescription3;
	
		// Properties
		public int Id { get; }
		public string GoodsName { get; }
		public string GoodsDescription { get; }
		public string IconImage { get; }
		public int GoodsCategory { get; }
		public int ServiceFlowType { get; }
		public int LabelType { get; }
		public int IsPickupDiamondGroup { get; }
		public int PackContentType { get; }
		public int PackContentSubType { get; }
		public int Priority { get; }
		public int ResetType { get; }
		public int Limit { get; }
		public QuestType ReleaseQuestType { get; }
		public int ReleaseQuestId { get; }
		public int LimitViewType { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
		public PaymentType PaymentType { get; }
		public int OptionValue { get; }
		public int PaymentRelationId { get; }
		public int NeedCost { get; }
		public int ViewPlatform { get; }
		public GiftType DestinationEntityType1 { get; }
		public int DestinationEntityId1 { get; }
		public int DestinationEntityQuantity1 { get; }
		public int DestinationLimitBreakCount1 { get; }
		public GiftType DestinationEntityType2 { get; }
		public int DestinationEntityId2 { get; }
		public int DestinationEntityQuantity2 { get; }
		public int DestinationLimitBreakCount2 { get; }
		public GiftType DestinationEntityType3 { get; }
		public int DestinationEntityId3 { get; }
		public int DestinationEntityQuantity3 { get; }
		public int DestinationLimitBreakCount3 { get; }
		public GiftType DestinationEntityType4 { get; }
		public int DestinationEntityId4 { get; }
		public int DestinationEntityQuantity4 { get; }
		public int DestinationLimitBreakCount4 { get; }
		public GiftType DestinationEntityType5 { get; }
		public int DestinationEntityId5 { get; }
		public int DestinationEntityQuantity5 { get; }
		public int DestinationLimitBreakCount5 { get; }
		public GiftType DestinationEntityType6 { get; }
		public int DestinationEntityId6 { get; }
		public int DestinationEntityQuantity6 { get; }
		public int DestinationLimitBreakCount6 { get; }
		public GiftType DestinationEntityType7 { get; }
		public int DestinationEntityId7 { get; }
		public int DestinationEntityQuantity7 { get; }
		public int DestinationLimitBreakCount7 { get; }
		public GiftType DestinationEntityType8 { get; }
		public int DestinationEntityId8 { get; }
		public int DestinationEntityQuantity8 { get; }
		public int DestinationLimitBreakCount8 { get; }
		public int BonusGoodsType { get; }
		public int BonusGoodsQuantity { get; }
		public int MissionPackGroupId { get; }
		public int AddMaxDragonQuantity { get; }
		public int AddMaxWeaponQuantity { get; }
		public int AddMaxAmuletQuantity { get; }
		public int AddStaminaSingle { get; }
		public int AddStaminaMulti { get; }
		public int GoodsType { get; }
		public int TargetSummonId { get; }
		public string DetailIcon1 { get; }
		public string DetailName1 { get; }
		public string DetailDescription1 { get; }
		public string DetailIcon2 { get; }
		public string DetailName2 { get; }
		public string DetailDescription2 { get; }
		public string DetailIcon3 { get; }
		public string DetailName3 { get; }
		public string DetailDescription3 { get; }
	
		// Constructors
		public SpecialShopElement();
	}
}
