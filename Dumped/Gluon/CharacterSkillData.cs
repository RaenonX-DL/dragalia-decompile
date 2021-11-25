using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterSkillData
	{
		[Flags]
		public enum SpRecoveryRule
		{
			Default = 0x0,
			DisableRecoverySpOnHit = 0x1
		}

		private enum TransCondition
		{
			None,
			HitDamageCollision,
			Cerese,
			HitImmediate
		}

		private enum SkillChainCondition
		{
			None = 0,
			EnemyBuffed = 1,
			EnemyBreaking = 2,
			Never = 98
		}

		public enum SkillChainResetReason
		{
			None,
			Timeout,
			EnterTransform,
			SupportSkill,
			PartySwitch
		}

		public const int maxTrans = 3;

		public const int maxChainData = 3;

		public const int maxEnhance = 3;

		public SkillDataElement elem;

		public SkillChainDataElement[] chainData;

		public int srcShareCharaId;

		public int srcShareCharaSkillIndex;

		public int dstBaseId;

		public int originSkillId;

		public int[] enhancedSkillId;

		public int level;

		public bool enableTrans;

		public bool pauseBuff;

		public bool isRunningTransAction;

		public List<PlayerActionElement> skillActions;

		private List<int> transTriggers;

		public EditSkillCharaOffsetElement shareSkillCoefData;

		public List<SkillDataElement> overChargeList;

		public int lastModeChangeSkillId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetupOverChargeData()
		{
		}

		public SkillDataElement GetTransSkillData(int phase)
		{
			return null;
		}

		public SkillDataElement GetNextTransSkillData()
		{
			return null;
		}

		public bool CheckTransSkill(CharacterBase owner, int skillIndex, CollisionHitAttribute attr)
		{
			return default(bool);
		}

		public void TransformSkill()
		{
		}

		public bool TransformOverChargeSkill(int phase)
		{
			return default(bool);
		}

		private bool TransformSkillImmediate(CharacterBase owner, int skillIndex, CollisionHitAttribute attr)
		{
			return default(bool);
		}

		private void TransformSkillImmediate_Internal(CharacterBase owner, SkillDataElement shiftElem)
		{
		}

		public void ReleaseTransSkill(CharacterBase owner)
		{
		}

		public bool IsExistTransSkill()
		{
			return default(bool);
		}

		public void DisableTrans()
		{
		}

		public bool ChangeMode(int skillId)
		{
			return default(bool);
		}

		public bool ChangeMode()
		{
			return default(bool);
		}

		public bool ResetMode()
		{
			return default(bool);
		}

		public void SetupChainData(SkillChainDataElement data)
		{
		}

		public int IsEnableChain(PlayerCharacter owner, bool isSameIndex)
		{
			return default(int);
		}

		private bool IsMatchChainCondition(PlayerCharacter owner, SkillChainDataElement data, bool isSameIndex)
		{
			return default(bool);
		}

		public bool IsActiveChain()
		{
			return default(bool);
		}

		public bool IsEnableSkillButtonAnim()
		{
			return default(bool);
		}

		public bool IsShareSkill()
		{
			return default(bool);
		}

		public bool HasRecoverySpRuleFlag(SpRecoveryRule flag)
		{
			return default(bool);
		}

		public bool CanResetChainSkill(SkillChainResetReason reason)
		{
			return default(bool);
		}

		public void OnReceiveTransSkill(CharacterBase owner, TransSkill recvEvent)
		{
		}
	}
}
