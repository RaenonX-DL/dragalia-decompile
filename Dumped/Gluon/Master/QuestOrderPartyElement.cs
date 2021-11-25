using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestOrderPartyElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _QuestOrderPartyGroupId;

		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _CharaLevel;

		[SerializeField]
		private int _CharaRarity;

		[SerializeField]
		private int _CharaHpPlusCount;

		[SerializeField]
		private int _CharaAttackPlusCount;

		[SerializeField]
		private int _ReleaseManaCircle;

		[SerializeField]
		private int _DragonId;

		[SerializeField]
		private int _DragonLevel;

		[SerializeField]
		private int _DragonLimitBreakCount;

		[SerializeField]
		private int _DragonHpPlusCount;

		[SerializeField]
		private int _DragonAttackPlusCount;

		[SerializeField]
		private int _WeaponSkinId;

		[SerializeField]
		private int _WeaponBodyId;

		[SerializeField]
		private int _WeaponBodyBuildupCount;

		[SerializeField]
		private int _WeaponBodyLimitBreakCount;

		[SerializeField]
		private int _WeaponBodyLimitOverCount;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestId1;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestBuildupCount1;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestLimitBreakCount1;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestHpPlusCount1;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestAttackPlusCount1;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestId2;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestBuildupCount2;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestLimitBreakCount2;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestHpPlusCount2;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestAttackPlusCount2;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestId3;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestBuildupCount3;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestLimitBreakCount3;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestHpPlusCount3;

		[SerializeField]
		private int _CrestSlotType1AbilityCrestAttackPlusCount3;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestId1;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestBuildupCount1;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestLimitBreakCount1;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestHpPlusCount1;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestAttackPlusCount1;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestId2;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestBuildupCount2;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestLimitBreakCount2;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestHpPlusCount2;

		[SerializeField]
		private int _CrestSlotType2AbilityCrestAttackPlusCount2;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestId1;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestBuildupCount1;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestLimitBreakCount1;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestHpPlusCount1;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestAttackPlusCount1;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestId2;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestBuildupCount2;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestLimitBreakCount2;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestHpPlusCount2;

		[SerializeField]
		private int _CrestSlotType3AbilityCrestAttackPlusCount2;

		public int Id => default(int);

		public int QuestOrderPartyGroupId => default(int);

		public int CharaId => default(int);

		public int CharaLevel => default(int);

		public int CharaRarity => default(int);

		public int CharaHpPlusCount => default(int);

		public int CharaAttackPlusCount => default(int);

		public int ReleaseManaCircle => default(int);

		public int DragonId => default(int);

		public int DragonLevel => default(int);

		public int DragonLimitBreakCount => default(int);

		public int DragonHpPlusCount => default(int);

		public int DragonAttackPlusCount => default(int);

		public int WeaponSkinId => default(int);

		public int WeaponBodyId => default(int);

		public int WeaponBodyBuildupCount => default(int);

		public int WeaponBodyLimitBreakCount => default(int);

		public int WeaponBodyLimitOverCount => default(int);

		public int CrestSlotType1AbilityCrestId1 => default(int);

		public int CrestSlotType1AbilityCrestBuildupCount1 => default(int);

		public int CrestSlotType1AbilityCrestLimitBreakCount1 => default(int);

		public int CrestSlotType1AbilityCrestHpPlusCount1 => default(int);

		public int CrestSlotType1AbilityCrestAttackPlusCount1 => default(int);

		public int CrestSlotType1AbilityCrestId2 => default(int);

		public int CrestSlotType1AbilityCrestBuildupCount2 => default(int);

		public int CrestSlotType1AbilityCrestLimitBreakCount2 => default(int);

		public int CrestSlotType1AbilityCrestHpPlusCount2 => default(int);

		public int CrestSlotType1AbilityCrestAttackPlusCount2 => default(int);

		public int CrestSlotType1AbilityCrestId3 => default(int);

		public int CrestSlotType1AbilityCrestBuildupCount3 => default(int);

		public int CrestSlotType1AbilityCrestLimitBreakCount3 => default(int);

		public int CrestSlotType1AbilityCrestHpPlusCount3 => default(int);

		public int CrestSlotType1AbilityCrestAttackPlusCount3 => default(int);

		public int CrestSlotType2AbilityCrestId1 => default(int);

		public int CrestSlotType2AbilityCrestBuildupCount1 => default(int);

		public int CrestSlotType2AbilityCrestLimitBreakCount1 => default(int);

		public int CrestSlotType2AbilityCrestHpPlusCount1 => default(int);

		public int CrestSlotType2AbilityCrestAttackPlusCount1 => default(int);

		public int CrestSlotType2AbilityCrestId2 => default(int);

		public int CrestSlotType2AbilityCrestBuildupCount2 => default(int);

		public int CrestSlotType2AbilityCrestLimitBreakCount2 => default(int);

		public int CrestSlotType2AbilityCrestHpPlusCount2 => default(int);

		public int CrestSlotType2AbilityCrestAttackPlusCount2 => default(int);

		public int CrestSlotType3AbilityCrestId1 => default(int);

		public int CrestSlotType3AbilityCrestBuildupCount1 => default(int);

		public int CrestSlotType3AbilityCrestLimitBreakCount1 => default(int);

		public int CrestSlotType3AbilityCrestHpPlusCount1 => default(int);

		public int CrestSlotType3AbilityCrestAttackPlusCount1 => default(int);

		public int CrestSlotType3AbilityCrestId2 => default(int);

		public int CrestSlotType3AbilityCrestBuildupCount2 => default(int);

		public int CrestSlotType3AbilityCrestLimitBreakCount2 => default(int);

		public int CrestSlotType3AbilityCrestHpPlusCount2 => default(int);

		public int CrestSlotType3AbilityCrestAttackPlusCount2 => default(int);
	}
}
