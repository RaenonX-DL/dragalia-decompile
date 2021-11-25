using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestRewardDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DropAstralItemQuantity;

		[SerializeField]
		private int _DropLimitBreakMaterialId;

		[SerializeField]
		private int _DropLimitBreakMaterialQuantity;

		[SerializeField]
		private int _LimitBreakMaterialDailyDrop;

		[SerializeField]
		private GiftType _FirstClearSetEntityType1;

		[SerializeField]
		private int _FirstClearSetEntityId1;

		[SerializeField]
		private int _FirstClearSetEntityQuantity1;

		[SerializeField]
		private GiftType _FirstClearSetEntityType2;

		[SerializeField]
		private int _FirstClearSetEntityId2;

		[SerializeField]
		private int _FirstClearSetEntityQuantity2;

		[SerializeField]
		private GiftType _FirstClearSetEntityType3;

		[SerializeField]
		private int _FirstClearSetEntityId3;

		[SerializeField]
		private int _FirstClearSetEntityQuantity3;

		[SerializeField]
		private GiftType _FirstClearSetEntityType4;

		[SerializeField]
		private int _FirstClearSetEntityId4;

		[SerializeField]
		private int _FirstClearSetEntityQuantity4;

		[SerializeField]
		private GiftType _FirstClearSetEntityType5;

		[SerializeField]
		private int _FirstClearSetEntityId5;

		[SerializeField]
		private int _FirstClearSetEntityQuantity5;

		[SerializeField]
		private Gluon.QuestMissionCompleteType _MissionCompleteType1;

		[SerializeField]
		private int _MissionCompleteValues1;

		[SerializeField]
		private Gluon.QuestMissionCompleteType _MissionCompleteType2;

		[SerializeField]
		private int _MissionCompleteValues2;

		[SerializeField]
		private Gluon.QuestMissionCompleteType _MissionCompleteType3;

		[SerializeField]
		private int _MissionCompleteValues3;

		[SerializeField]
		private int _QuestScoreMissionId;

		[SerializeField]
		private GiftType _MissionsClearSetEntityType1;

		[SerializeField]
		private int _MissionsClearSetEntityId1;

		[SerializeField]
		private int _MissionsClearSetEntityQuantity1;

		[SerializeField]
		private GiftType _MissionsClearSetEntityType2;

		[SerializeField]
		private int _MissionsClearSetEntityId2;

		[SerializeField]
		private int _MissionsClearSetEntityQuantity2;

		[SerializeField]
		private GiftType _MissionsClearSetEntityType3;

		[SerializeField]
		private int _MissionsClearSetEntityId3;

		[SerializeField]
		private int _MissionsClearSetEntityQuantity3;

		[SerializeField]
		private GiftType _MissionCompleteEntityType;

		[SerializeField]
		private int _MissionCompleteEntityId;

		[SerializeField]
		private int _MissionCompleteEntityQuantity;

		[SerializeField]
		private int _QuestScoringEnemyGroupId;

		public int Id => default(int);

		public int DropAstralItemQuantity => default(int);

		public int DropLimitBreakMaterialId => default(int);

		public int DropLimitBreakMaterialQuantity => default(int);

		public int LimitBreakMaterialDailyDrop => default(int);

		public GiftType FirstClearSetEntityType1 => default(GiftType);

		public int FirstClearSetEntityId1 => default(int);

		public int FirstClearSetEntityQuantity1 => default(int);

		public GiftType FirstClearSetEntityType2 => default(GiftType);

		public int FirstClearSetEntityId2 => default(int);

		public int FirstClearSetEntityQuantity2 => default(int);

		public GiftType FirstClearSetEntityType3 => default(GiftType);

		public int FirstClearSetEntityId3 => default(int);

		public int FirstClearSetEntityQuantity3 => default(int);

		public GiftType FirstClearSetEntityType4 => default(GiftType);

		public int FirstClearSetEntityId4 => default(int);

		public int FirstClearSetEntityQuantity4 => default(int);

		public GiftType FirstClearSetEntityType5 => default(GiftType);

		public int FirstClearSetEntityId5 => default(int);

		public int FirstClearSetEntityQuantity5 => default(int);

		public Gluon.QuestMissionCompleteType MissionCompleteType1 => default(Gluon.QuestMissionCompleteType);

		public int MissionCompleteValues1 => default(int);

		public Gluon.QuestMissionCompleteType MissionCompleteType2 => default(Gluon.QuestMissionCompleteType);

		public int MissionCompleteValues2 => default(int);

		public Gluon.QuestMissionCompleteType MissionCompleteType3 => default(Gluon.QuestMissionCompleteType);

		public int MissionCompleteValues3 => default(int);

		public int QuestScoreMissionId => default(int);

		public GiftType MissionsClearSetEntityType1 => default(GiftType);

		public int MissionsClearSetEntityId1 => default(int);

		public int MissionsClearSetEntityQuantity1 => default(int);

		public GiftType MissionsClearSetEntityType2 => default(GiftType);

		public int MissionsClearSetEntityId2 => default(int);

		public int MissionsClearSetEntityQuantity2 => default(int);

		public GiftType MissionsClearSetEntityType3 => default(GiftType);

		public int MissionsClearSetEntityId3 => default(int);

		public int MissionsClearSetEntityQuantity3 => default(int);

		public GiftType MissionCompleteEntityType => default(GiftType);

		public int MissionCompleteEntityId => default(int);

		public int MissionCompleteEntityQuantity => default(int);

		public int QuestScoringEnemyGroupId => default(int);
	}
}
