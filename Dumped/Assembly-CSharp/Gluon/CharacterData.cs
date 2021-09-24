/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterData
	{
		// Fields
		[CompilerGenerated]
		private CharaDataWrapper _masterData_k__BackingField;
		[CompilerGenerated]
		private int _level_k__BackingField;
		[CompilerGenerated]
		private int _hp_k__BackingField;
		[CompilerGenerated]
		private int _attack_k__BackingField;
		[CompilerGenerated]
		private int _defense_k__BackingField;
		private string[] voiceSoundGroup;
	
		// Properties
		public CharaDataWrapper masterData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int level { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int hp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int attack { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int defense { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string[] VoiceSoundGroup { get; }
	
		// Nested types
		public class CharaDataWrapper
		{
			// Fields
			private CharaDataElement original;
			private CharaDataElement brChara;
	
			// Properties
			public CharaDataElement Original { get; }
			public int Id { get; }
			public int BaseId { get; }
			public int VariationId { get; }
			public WeaponType WeaponType { get; }
			public string Name { get; }
			public string SecondName { get; }
			public int VoiceType { get; }
			public int Win { get; }
			public CharaFaceEyeMotion WinFaceEyeMotion { get; }
			public CharaFaceMouthMotion WinFaceMouthMotion { get; }
			public int Appear { get; }
			public int Disappear { get; }
			public int Revive { get; }
			public string EffNameCriticalHit { get; }
			public int EditSkillRelationId { get; }
			public int FootprintsType { get; }
			public int SpecialOndamageVoice { get; }
			public int BaseAuraMaxLimitLevel { get; }
			public int SupportSkillNum { get; }
			public ElementalType ElementalType { get; }
			public WeaponAttackRangeType AttackRangeType { get; }
			public int DashAttack { get; }
			public int BurstAttack { get; }
			public int Avoid { get; }
			public int BackAvoidOnCombo { get; }
			public int AvoidOnCombo { get; }
			public float SearchRange { get; }
			public float SearchAngle { get; }
			public float DefCoef { get; }
			public float SkillChainValidTime { get; }
			public float SkillChainSpbarCount { get; }
			public int IsConvertDragonSkillLevel { get; }
			public int Skill1 { get; }
			public int Skill2 { get; }
			public int Abilities11 { get; }
			public int Abilities12 { get; }
			public int Abilities13 { get; }
			public int Abilities14 { get; }
			public int Abilities21 { get; }
			public int Abilities22 { get; }
			public int Abilities23 { get; }
			public int Abilities24 { get; }
			public int Abilities31 { get; }
			public int Abilities32 { get; }
			public int Abilities33 { get; }
			public int Abilities34 { get; }
			public int ExAbilityData1 { get; }
			public int ExAbilityData2 { get; }
			public int ExAbilityData3 { get; }
			public int ExAbilityData4 { get; }
			public int ExAbilityData5 { get; }
			public int ModeId1 { get; }
			public int ModeId2 { get; }
			public int ModeId3 { get; }
			public int ModeId4 { get; }
			public int ChargeType { get; }
			public int MaxChargeLv { get; }
			public int OnChangeBADuringCharge { get; }
			public int UniqueWeaponSkinId { get; }
			public int UniqueDragonId { get; }
			public int ModeChangeType { get; }
			public int Mode1Combo { get; }
			public int Mode2Combo { get; }
			public int AttachWeaponHandType { get; }
	
			// Constructors
			public CharaDataWrapper();
	
			// Methods
			public void Setup(CharaDataElement elem);
		}
	
		// Constructors
		public CharacterData(int characterId, int level);
	
		// Methods
		public bool Setup(int baseHp, int baseAtk, int baseDef);
	}
}
