using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class PlayerData
	{
		private static int skillNumForDmode;

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

		public static int skillNum => default(int);

		public int enhancedBurstAttackId
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

		public int enhancedAbilityBurstAttackId
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

		public event Action<int, int> onSkillChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetupSkill(HeroParam param, CharacterData chara, WeaponData weapon, bool isSupporter)
		{
		}

		public void SetupSkillForBR(BRCharaCtrl brCharaCtrl, int brSpecialSkillId)
		{
		}

		public void SetupSkillForDmode(CharacterData.CharaDataWrapper charaData)
		{
		}

		public void ClearSkillForDmode()
		{
		}

		private void SetupShareSkill(int srcShareCharaId, int skillIndex, int relationId, int dstBaseId)
		{
		}

		private void SetOriginalModeSkill(int skillId)
		{
		}

		public void SetupAbility(HeroParam param, CharacterData chara)
		{
		}

		private void AddSkillAction(CharacterSkillData data, int skillIndex)
		{
		}

		private void AddSkillAction(CharacterSkillData data, int actionId, int skillIndex)
		{
		}

		private void AddNextAction(CharacterSkillData data, PlayerActionElement pae)
		{
		}

		public void SetupEnhancedSkill(int skillIndex, int skillId)
		{
		}

		public void ResetEnhancedSkill(int skillIndex)
		{
		}

		public bool CheckTransSkill(CharacterBase owner, CollisionHitAttribute attr, int idx)
		{
			return default(bool);
		}

		public void TransformSkill(int idx)
		{
		}

		public void ReleaseTransSkill(CharacterBase owner, int idx)
		{
		}

		public void DisableTrans(int idx)
		{
		}

		public bool IsPauseTransBuff(int idx)
		{
			return default(bool);
		}

		public void PauseTransBuff(int idx, bool pause)
		{
		}

		public void ChangeMode(int idx)
		{
		}

		public void ResetMode(int idx)
		{
		}

		public void ChangeModeForButton(int idx, int modeId)
		{
		}

		private void SetupSkillChainData(CharacterSkillData data)
		{
		}

		public bool SetChainSkill(int idx, int skillId)
		{
			return default(bool);
		}

		public bool ResetChainSkill(int idx, CharacterSkillData.SkillChainResetReason reason)
		{
			return default(bool);
		}

		public void OnReceiveTransSkill(CharacterBase owner, TransSkill recvEvent)
		{
		}

		public void SetRequireSp(int idx)
		{
		}
	}
}
