using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponCraftDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _FortCraftLevel;

		[SerializeField]
		private int _AcquiredWeaponId1;

		[SerializeField]
		private int _AcquiredWeaponId2;

		[SerializeField]
		private int _AssembleCoin;

		[SerializeField]
		private int _IsLimitBreakMax;

		[SerializeField]
		private int _IsUnableDisassemble;

		[SerializeField]
		private int _DisassembleCoin;

		[SerializeField]
		private int _DisassembleCost;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		[SerializeField]
		private int _MainWeaponId;

		[SerializeField]
		private int _MainWeaponQuantity;

		[SerializeField]
		private int _WeaponSetId1;

		[SerializeField]
		private int _WeaponSetId2;

		[SerializeField]
		private int _WeaponSetId3;

		[SerializeField]
		private int _WeaponSetId4;

		[SerializeField]
		private int _WeaponSetId5;

		[SerializeField]
		private GiftType _CraftEntityType1;

		[SerializeField]
		private int _CraftEntityId1;

		[SerializeField]
		private int _CraftEntityQuantity1;

		[SerializeField]
		private GiftType _CraftEntityType2;

		[SerializeField]
		private int _CraftEntityId2;

		[SerializeField]
		private int _CraftEntityQuantity2;

		[SerializeField]
		private GiftType _CraftEntityType3;

		[SerializeField]
		private int _CraftEntityId3;

		[SerializeField]
		private int _CraftEntityQuantity3;

		[SerializeField]
		private GiftType _CraftEntityType4;

		[SerializeField]
		private int _CraftEntityId4;

		[SerializeField]
		private int _CraftEntityQuantity4;

		[SerializeField]
		private GiftType _CraftEntityType5;

		[SerializeField]
		private int _CraftEntityId5;

		[SerializeField]
		private int _CraftEntityQuantity5;

		public int Id => default(int);

		public int FortCraftLevel => default(int);

		public int AcquiredWeaponId1 => default(int);

		public int AcquiredWeaponId2 => default(int);

		public int AssembleCoin => default(int);

		public int IsLimitBreakMax => default(int);

		public int IsUnableDisassemble => default(int);

		public int DisassembleCoin => default(int);

		public int DisassembleCost => default(int);

		public string StartDate => null;

		public string EndDate => null;

		public int MainWeaponId => default(int);

		public int MainWeaponQuantity => default(int);

		public int WeaponSetId1 => default(int);

		public int WeaponSetId2 => default(int);

		public int WeaponSetId3 => default(int);

		public int WeaponSetId4 => default(int);

		public int WeaponSetId5 => default(int);

		public GiftType CraftEntityType1 => default(GiftType);

		public int CraftEntityId1 => default(int);

		public int CraftEntityQuantity1 => default(int);

		public GiftType CraftEntityType2 => default(GiftType);

		public int CraftEntityId2 => default(int);

		public int CraftEntityQuantity2 => default(int);

		public GiftType CraftEntityType3 => default(GiftType);

		public int CraftEntityId3 => default(int);

		public int CraftEntityQuantity3 => default(int);

		public GiftType CraftEntityType4 => default(GiftType);

		public int CraftEntityId4 => default(int);

		public int CraftEntityQuantity4 => default(int);

		public GiftType CraftEntityType5 => default(GiftType);

		public int CraftEntityId5 => default(int);

		public int CraftEntityQuantity5 => default(int);
	}
}
