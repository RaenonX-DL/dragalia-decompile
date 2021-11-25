using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestWallDetailElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _WallId;

		[SerializeField]
		private int _WallLevel;

		[SerializeField]
		private Gluon.ElementalType _LimitedElementalType;

		[SerializeField]
		private int _Difficulty;

		[SerializeField]
		private Gluon.QuestClearType _ClearTermsType;

		[SerializeField]
		private Gluon.QuestFailedType _FailedTermsType;

		[SerializeField]
		private float _FailedTermsTimeElapsed;

		[SerializeField]
		private DungeonType _DungeonType;

		[SerializeField]
		private string _Scene01;

		[SerializeField]
		private string _AreaName01;

		[SerializeField]
		private string _WallBgm;

		[SerializeField]
		private int _BossEnemyParamId;

		[SerializeField]
		private Gluon.AbnormalStatusType _WallAbnormalStatusType1;

		[SerializeField]
		private Gluon.AbnormalStatusType _WallAbnormalStatusType2;

		[SerializeField]
		private Gluon.AbnormalStatusType _WallAbnormalStatusType3;

		[SerializeField]
		private GiftType _DropEntityType1;

		[SerializeField]
		private int _DropEntityId1;

		[SerializeField]
		private int _DropEntityQuantity1;

		[SerializeField]
		private GiftType _DropEntityType2;

		[SerializeField]
		private int _DropEntityId2;

		[SerializeField]
		private int _DropEntityQuantity2;

		[SerializeField]
		private GiftType _DropEntityType3;

		[SerializeField]
		private int _DropEntityId3;

		[SerializeField]
		private int _DropEntityQuantity3;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private int _ClearCoin;

		[SerializeField]
		private int _ClearMana;

		[SerializeField]
		private GiftType _ClearEntityType1;

		[SerializeField]
		private int _ClearEntityId1;

		[SerializeField]
		private int _ClearEntityQuantity1;

		[SerializeField]
		private GiftType _ClearEntityType2;

		[SerializeField]
		private int _ClearEntityId2;

		[SerializeField]
		private int _ClearEntityQuantity2;

		[SerializeField]
		private GiftType _ClearEntityType3;

		[SerializeField]
		private int _ClearEntityId3;

		[SerializeField]
		private int _ClearEntityQuantity3;

		[SerializeField]
		private GiftType _ClearEntityType4;

		[SerializeField]
		private int _ClearEntityId4;

		[SerializeField]
		private int _ClearEntityQuantity4;

		[SerializeField]
		private GiftType _ClearEntityType5;

		[SerializeField]
		private int _ClearEntityId5;

		[SerializeField]
		private int _ClearEntityQuantity5;

		public int Id => default(int);

		public int WallId => default(int);

		public int WallLevel => default(int);

		public Gluon.ElementalType LimitedElementalType => default(Gluon.ElementalType);

		public int Difficulty => default(int);

		public Gluon.QuestClearType ClearTermsType => default(Gluon.QuestClearType);

		public Gluon.QuestFailedType FailedTermsType => default(Gluon.QuestFailedType);

		public float FailedTermsTimeElapsed => default(float);

		public DungeonType DungeonType => default(DungeonType);

		public string Scene01 => null;

		public string AreaName01 => null;

		public string WallBgm => null;

		public int BossEnemyParamId => default(int);

		public Gluon.AbnormalStatusType WallAbnormalStatusType1 => default(Gluon.AbnormalStatusType);

		public Gluon.AbnormalStatusType WallAbnormalStatusType2 => default(Gluon.AbnormalStatusType);

		public Gluon.AbnormalStatusType WallAbnormalStatusType3 => default(Gluon.AbnormalStatusType);

		public GiftType DropEntityType1 => default(GiftType);

		public int DropEntityId1 => default(int);

		public int DropEntityQuantity1 => default(int);

		public GiftType DropEntityType2 => default(GiftType);

		public int DropEntityId2 => default(int);

		public int DropEntityQuantity2 => default(int);

		public GiftType DropEntityType3 => default(GiftType);

		public int DropEntityId3 => default(int);

		public int DropEntityQuantity3 => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public int ClearCoin => default(int);

		public int ClearMana => default(int);

		public GiftType ClearEntityType1 => default(GiftType);

		public int ClearEntityId1 => default(int);

		public int ClearEntityQuantity1 => default(int);

		public GiftType ClearEntityType2 => default(GiftType);

		public int ClearEntityId2 => default(int);

		public int ClearEntityQuantity2 => default(int);

		public GiftType ClearEntityType3 => default(GiftType);

		public int ClearEntityId3 => default(int);

		public int ClearEntityQuantity3 => default(int);

		public GiftType ClearEntityType4 => default(GiftType);

		public int ClearEntityId4 => default(int);

		public int ClearEntityQuantity4 => default(int);

		public GiftType ClearEntityType5 => default(GiftType);

		public int ClearEntityId5 => default(int);

		public int ClearEntityQuantity5 => default(int);
	}
}
