using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class CharacterData
	{
		public class CharaDataWrapper
		{
			private CharaDataElement original;

			private CharaDataElement brChara;

			public CharaDataElement Original => null;

			public int Id => default(int);

			public int BaseId => default(int);

			public int VariationId => default(int);

			public WeaponType WeaponType => default(WeaponType);

			public string Name => null;

			public string SecondName => null;

			public int VoiceType => default(int);

			public int Win => default(int);

			public CharaFaceEyeMotion WinFaceEyeMotion => default(CharaFaceEyeMotion);

			public CharaFaceMouthMotion WinFaceMouthMotion => default(CharaFaceMouthMotion);

			public int Appear => default(int);

			public int Disappear => default(int);

			public int Revive => default(int);

			public string EffNameCriticalHit => null;

			public int EditSkillRelationId => default(int);

			public int FootprintsType => default(int);

			public int SpecialOndamageVoice => default(int);

			public int BaseAuraMaxLimitLevel => default(int);

			public int SupportSkillNum => default(int);

			public ElementalType ElementalType => default(ElementalType);

			public WeaponAttackRangeType AttackRangeType => default(WeaponAttackRangeType);

			public int DashAttack => default(int);

			public int BurstAttack => default(int);

			public int Avoid => default(int);

			public int BackAvoidOnCombo => default(int);

			public int AvoidOnCombo => default(int);

			public int Guts => default(int);

			public float SearchRange => default(float);

			public float SearchAngle => default(float);

			public float DefCoef => default(float);

			public float SkillChainValidTime => default(float);

			public float SkillChainSpbarCount => default(float);

			public int IsConvertDragonSkillLevel => default(int);

			public int Skill1 => default(int);

			public int Skill2 => default(int);

			public int Abilities11 => default(int);

			public int Abilities12 => default(int);

			public int Abilities13 => default(int);

			public int Abilities14 => default(int);

			public int Abilities21 => default(int);

			public int Abilities22 => default(int);

			public int Abilities23 => default(int);

			public int Abilities24 => default(int);

			public int Abilities31 => default(int);

			public int Abilities32 => default(int);

			public int Abilities33 => default(int);

			public int Abilities34 => default(int);

			public int ExAbilityData1 => default(int);

			public int ExAbilityData2 => default(int);

			public int ExAbilityData3 => default(int);

			public int ExAbilityData4 => default(int);

			public int ExAbilityData5 => default(int);

			public int ModeId1 => default(int);

			public int ModeId2 => default(int);

			public int ModeId3 => default(int);

			public int ModeId4 => default(int);

			public int ChargeType => default(int);

			public int MaxChargeLv => default(int);

			public int OnChangeBADuringCharge => default(int);

			public int UniqueWeaponSkinId => default(int);

			public int UniqueDragonId => default(int);

			public int ModeChangeType => default(int);

			public int Mode1Combo => default(int);

			public int Mode2Combo => default(int);

			public int AttachWeaponHandType => default(int);

			public void Setup(CharaDataElement elem)
			{
			}
		}

		private string[] voiceSoundGroup;

		public CharaDataWrapper masterData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int level
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int hp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int attack
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int defense
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string[] VoiceSoundGroup => null;

		public CharacterData(int characterId, int level)
		{
		}

		public bool Setup(int baseHp, int baseAtk, int baseDef)
		{
			return default(bool);
		}
	}
}
