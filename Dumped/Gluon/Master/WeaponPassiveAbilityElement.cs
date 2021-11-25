using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponPassiveAbilityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _WeaponPassiveAbilityGroupId;

		[SerializeField]
		private int _WeaponPassiveAbilityNo;

		[SerializeField]
		private Gluon.WeaponType _WeaponType;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _UnlockConditionLimitBreakCount;

		[SerializeField]
		private int _AbilityId;

		[SerializeField]
		private int _RewardWeaponSkinId1;

		[SerializeField]
		private int _RewardWeaponSkinId2;

		[SerializeField]
		private int _UnlockCoin;

		[SerializeField]
		private int _UnlockMaterialId1;

		[SerializeField]
		private int _UnlockMaterialQuantity1;

		[SerializeField]
		private int _UnlockMaterialId2;

		[SerializeField]
		private int _UnlockMaterialQuantity2;

		[SerializeField]
		private int _UnlockMaterialId3;

		[SerializeField]
		private int _UnlockMaterialQuantity3;

		[SerializeField]
		private int _UnlockMaterialId4;

		[SerializeField]
		private int _UnlockMaterialQuantity4;

		[SerializeField]
		private int _UnlockMaterialId5;

		[SerializeField]
		private int _UnlockMaterialQuantity5;

		public int Id => default(int);

		public int WeaponPassiveAbilityGroupId => default(int);

		public int WeaponPassiveAbilityNo => default(int);

		public Gluon.WeaponType WeaponType => default(Gluon.WeaponType);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int SortId => default(int);

		public int UnlockConditionLimitBreakCount => default(int);

		public int AbilityId => default(int);

		public int RewardWeaponSkinId1 => default(int);

		public int RewardWeaponSkinId2 => default(int);

		public int UnlockCoin => default(int);

		public int UnlockMaterialId1 => default(int);

		public int UnlockMaterialQuantity1 => default(int);

		public int UnlockMaterialId2 => default(int);

		public int UnlockMaterialQuantity2 => default(int);

		public int UnlockMaterialId3 => default(int);

		public int UnlockMaterialQuantity3 => default(int);

		public int UnlockMaterialId4 => default(int);

		public int UnlockMaterialQuantity4 => default(int);

		public int UnlockMaterialId5 => default(int);

		public int UnlockMaterialQuantity5 => default(int);
	}
}
