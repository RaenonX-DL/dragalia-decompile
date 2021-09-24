/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterSkillData
	{
		// Fields
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
		[CompilerGenerated]
		private int _lastModeChangeSkillId_k__BackingField;
		public int level;
		public bool enableTrans;
		public bool pauseBuff;
		public bool isRunningTransAction;
		public List<PlayerActionElement> skillActions;
		private List<int> transTriggers;
		public EditSkillCharaOffsetElement shareSkillCoefData;
		public List<SkillDataElement> overChargeList;
	
		// Properties
		public int lastModeChangeSkillId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Flags]
		public enum SpRecoveryRule
		{
			Default = 0,
			DisableRecoverySpOnHit = 1
		}
	
		private enum TransCondition
		{
			None = 0,
			HitDamageCollision = 1,
			Cerese = 2,
			HitImmediate = 3
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
			None = 0,
			Timeout = 1,
			EnterTransform = 2,
			SupportSkill = 3,
			PartySwitch = 4
		}
	
		// Constructors
		public CharacterSkillData();
	
		// Methods
		public void SetupOverChargeData();
		public SkillDataElement GetTransSkillData(int phase);
		public SkillDataElement GetNextTransSkillData();
		public bool CheckTransSkill(CharacterBase owner, int skillIndex, CollisionHitAttribute attr);
		public void TransformSkill();
		public bool TransformOverChargeSkill(int phase);
		private bool TransformSkillImmediate(CharacterBase owner, int skillIndex, CollisionHitAttribute attr);
		private void TransformSkillImmediate_Internal(CharacterBase owner, SkillDataElement shiftElem);
		public void ReleaseTransSkill(CharacterBase owner);
		public bool IsExistTransSkill();
		public void DisableTrans();
		public bool ChangeMode(int skillId);
		public bool ChangeMode();
		public bool ResetMode();
		public void SetupChainData(SkillChainDataElement data);
		public int IsEnableChain(PlayerCharacter owner, bool isSameIndex);
		private bool IsMatchChainCondition(PlayerCharacter owner, SkillChainDataElement data, bool isSameIndex);
		public bool IsActiveChain();
		public bool IsEnableSkillButtonAnim();
		public bool IsShareSkill();
		public bool HasRecoverySpRuleFlag(SpRecoveryRule flag);
		public bool CanResetChainSkill(SkillChainResetReason reason);
		public void OnReceiveTransSkill(CharacterBase owner, TransSkill recvEvent);
		[CompilerGenerated]
		private void _TransformSkillImmediate_Internal_b__33_0(ActionBase x);
	}
}
