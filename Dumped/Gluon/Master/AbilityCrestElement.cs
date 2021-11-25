using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityCrestElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private AbilityCrestType _AbilityCrestType;

		[SerializeField]
		private AblitiyCrestSlotType _CrestSlotType;

		[SerializeField]
		private UnitType _UnitType;

		[SerializeField]
		private int _AbilityCrestFeatureGroupId;

		[SerializeField]
		private int _MaxEquipableCount;

		[SerializeField]
		private int _BaseHp;

		[SerializeField]
		private int _MaxHp;

		[SerializeField]
		private int _BaseAtk;

		[SerializeField]
		private int _MaxAtk;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _IsHideChangeImage;

		[SerializeField]
		private int _UnionAbilityGroupId;

		[SerializeField]
		private int _Abilities11;

		[SerializeField]
		private int _Abilities12;

		[SerializeField]
		private int _Abilities13;

		[SerializeField]
		private int _Abilities21;

		[SerializeField]
		private int _Abilities22;

		[SerializeField]
		private int _Abilities23;

		[SerializeField]
		private string _CvInfo;

		[SerializeField]
		private string _Text1;

		[SerializeField]
		private string _Text2;

		[SerializeField]
		private string _Text3;

		[SerializeField]
		private string _Text4;

		[SerializeField]
		private string _Text5;

		[SerializeField]
		private int _IsPlayable;

		[SerializeField]
		private int _UniqueBuildupMaterialId;

		[SerializeField]
		private GiftType _DuplicateEntityType;

		[SerializeField]
		private int _DuplicateEntityId;

		[SerializeField]
		private int _DuplicateEntityQuantity;

		[SerializeField]
		private int _AbilityCrestLevelRarityGroupId;

		[SerializeField]
		private int _AbilityCrestBuildupGroupId;

		public int Id => default(int);

		public string Name => null;

		public int Rarity => default(int);

		public AbilityCrestType AbilityCrestType => default(AbilityCrestType);

		public AblitiyCrestSlotType CrestSlotType => default(AblitiyCrestSlotType);

		public UnitType UnitType => default(UnitType);

		public int AbilityCrestFeatureGroupId => default(int);

		public int MaxEquipableCount => default(int);

		public int BaseHp => default(int);

		public int MaxHp => default(int);

		public int BaseAtk => default(int);

		public int MaxAtk => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int IsHideChangeImage => default(int);

		public int UnionAbilityGroupId => default(int);

		public int Abilities11 => default(int);

		public int Abilities12 => default(int);

		public int Abilities13 => default(int);

		public int Abilities21 => default(int);

		public int Abilities22 => default(int);

		public int Abilities23 => default(int);

		public string CvInfo => null;

		public string Text1 => null;

		public string Text2 => null;

		public string Text3 => null;

		public string Text4 => null;

		public string Text5 => null;

		public int IsPlayable => default(int);

		public int UniqueBuildupMaterialId => default(int);

		public GiftType DuplicateEntityType => default(GiftType);

		public int DuplicateEntityId => default(int);

		public int DuplicateEntityQuantity => default(int);

		public int AbilityCrestLevelRarityGroupId => default(int);

		public int AbilityCrestBuildupGroupId => default(int);
	}
}
