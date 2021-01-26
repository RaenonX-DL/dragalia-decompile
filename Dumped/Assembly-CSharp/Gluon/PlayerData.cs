/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerData
	{
		// Fields
		public AbilityDataElement[] abilityData;
		public int[] abilityLv;
		public ExAbilityDataElement exAbilityData;
		public AbilityDataElement[] eventAbilityData;
		public List<AbilityDataElement> weaponPassiveAbilities;
		public int comboLv;
		public int burstAttackLv;
		public int exAbilityLv;
		public CharacterSkillData[] skillData;
		public List<PlayerActionElement> nextActions;
		[CompilerGenerated]
		private int _enhancedBurstAttackId_k__BackingField;
		[CompilerGenerated]
		private int _enhancedAbilityBurstAttackId_k__BackingField;
		[CompilerGenerated]
		private Action<int, int> onSkillChange;
	
		// Properties
		public static int skillNum { get; }
		public int enhancedBurstAttackId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int enhancedAbilityBurstAttackId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Events
		public event Action<int, int> onSkillChange {
			add;
			remove;
		}
	
		// Constructors
		public PlayerData();
	
		// Methods
		public void SetupSkill(HeroParam param, CharacterData chara, WeaponData weapon, bool isSupporter);
		public void SetupSkillForBR(BRCharaCtrl brCharaCtrl, int brSpecialSkillId);
		private void SetupShareSkill(int srcShareCharaId, int skillIndex, int relationId, int dstBaseId);
		private void SetOriginalModeSkill(int skillId);
		public void SetupAbility(HeroParam param, CharacterData chara);
		private void AddSkillAction(CharacterSkillData data, int skillIndex);
		private void AddSkillAction(CharacterSkillData data, int actionId, int skillIndex);
		private void AddNextAction(CharacterSkillData data, PlayerActionElement pae);
		public void SetupEnhancedSkill(int skillIndex, int skillId);
		public void ResetEnhancedSkill(int skillIndex);
		public bool CheckTransSkill(CollisionHitAttribute attr, int idx);
		public void TransformSkill(int idx);
		public void ReleaseTransSkill(CharacterBase owner, int idx);
		public void DisableTrans(int idx);
		public bool IsPauseTransBuff(int idx);
		public void PauseTransBuff(int idx, bool pause);
		public void ChangeMode(int idx);
		public void ResetMode(int idx);
		public void ChangeModeForButton(int idx, int modeId);
		private void SetupSkillChainData(CharacterSkillData data);
		public bool SetChainSkill(int idx, int skillId);
		public void ResetChainSkill(int idx);
		private void SetRequireSp(int idx);
	}
}
