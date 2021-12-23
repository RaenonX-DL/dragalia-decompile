using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class DragonCharacter : PlayerCharacter
	{
		public enum ServantAIType
		{
			Normal,
			CommandWait
		}

		public enum ServantActionCommand
		{
			None,
			Combo1,
			Combo2,
			Combo3,
			Combo4,
			Combo5,
			Skill1,
			Skill2
		}

		public struct SearvantActionData
		{
			public ServantActionCommand commandId;

			public int actionId;
		}

		private HumanCharacter _human;

		private bool isPauseDragonTime;

		private int maxChargeLevel;

		public static readonly float dragonFlashingTime;

		private ServantAIType servantAIType;

		public override FollowerAIBase followerAI => null;

		public override string DebugName => null;

		public HumanCharacter human => null;

		public DragonData dragonData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public float dragonTimer
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float maxDragonTimer
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float dragonTimerRate => default(float);

		public bool isServant
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isServitor
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isDragonMode2
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isUpdateDragonTime
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isReleaseTransformForDamaged
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isEnhanceModeEnd
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int skillUseNum
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

		public List<SearvantActionData> servantActions
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

		public Vector3 servantFollowPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static DragonCharacter Create(HeroParam param, HumanCharacter character, GameObject parent, int layer, bool isNeedShadow, bool isOtherPlayer, int actorIndex, bool isServitor, [Optional] CharacterManager charaManager)
		{
			return null;
		}

		public static DragonCharacter CreateReserve(int originId, HumanCharacter character, GameObject parent, int actorIndex)
		{
			return null;
		}

		public override int GetSortingOrderOffset()
		{
			return default(int);
		}

		public override float ShadowSize()
		{
			return default(float);
		}

		public void Initialize(int characterId, int uniqueDragonId, bool isNeedShadow, int actorIndex)
		{
		}

		private void LoadAction(bool isOtherPlayer)
		{
		}

		public void AddLoadFinalAttackAction(List<int> actions)
		{
		}

		private void AttachDragonDecoration()
		{
		}

		private void AttachDragonDecoration(int decoId)
		{
		}

		public void SetupDragon(HumanCharacter character, HeroParam heroParam, bool isOtherPlayer, bool needsOverrideDragonData = true)
		{
		}

		private void SetupDragonInActionEditor(HumanCharacter character, int dragonId, int uniqueDragonId, int dragonLv)
		{
		}

		private void SetupServitor(HumanCharacter character, HeroParam heroParam, bool isOtherPlayer)
		{
		}

		private void SetupServitorDragonData()
		{
		}

		private void SetupReserveDragonData()
		{
		}

		private void SetupEnhanceGauge()
		{
		}

		public override void SetupAbilityCommonData(bool isQuestStart)
		{
		}

		private void SetupOverCharge()
		{
		}

		public void TakeOverStatus(HumanCharacter chara)
		{
		}

		public void ShareParameter(HumanCharacter chara)
		{
		}

		public override void ReleaseUniqueTransform(bool isCancel)
		{
		}

		public bool IsHpInfinity(bool ignoreCheckDragonQuest = false)
		{
			return default(bool);
		}

		public override void FastUpdate()
		{
		}

		public override void SetFaceType(FaceType type, bool force = false)
		{
		}

		public override void LateUpdate()
		{
		}

		public override int GetSkillNum()
		{
			return default(int);
		}

		public override CharacterSkillData GetSkillData(int index)
		{
			return null;
		}

		public override SkillDataElement GetSkillDataElement(int index)
		{
			return null;
		}

		public override SkillDataElement GetTransSkillDataElement(int index, int phase)
		{
			return null;
		}

		public override SkillDataElement GetNextTransSkillDataElement(int index)
		{
			return null;
		}

		public override TribeType GetTribe()
		{
			return default(TribeType);
		}

		public override bool IsCombo(int actionId)
		{
			return default(bool);
		}

		public override int GetComboAttackId(int idx, bool ex)
		{
			return default(int);
		}

		public override int GetMaxCombo()
		{
			return default(int);
		}

		public override int GetDragonTransformActionId()
		{
			return default(int);
		}

		public override int GetAvoidActionId(InGameDef.Direction dir)
		{
			return default(int);
		}

		public override int[] GetAllAvoidActions(InGameDef.Direction dir)
		{
			return null;
		}

		protected override float AvoidDirectionCoef(InGameDef.Direction dirType, int actionId)
		{
			return default(float);
		}

		private int GetActualEnhancedLeveledBurstAttackActionId()
		{
			return default(int);
		}

		public override int GetBurstAttackActionId()
		{
			return default(int);
		}

		private int GetChargeRelationActionId(InGameDef.BurstActionOffset step)
		{
			return default(int);
		}

		public override int GetChargeStartActionId()
		{
			return default(int);
		}

		public override int GetChargeLoopActionId()
		{
			return default(int);
		}

		public override int GetChargeCancelActionId()
		{
			return default(int);
		}

		public override int GetChargeMarkerActionId()
		{
			return default(int);
		}

		public bool HasBurstAttack()
		{
			return default(bool);
		}

		public void SetMaxChargeLevel(int level)
		{
		}

		public override int GetMaxChargeLv()
		{
			return default(int);
		}

		protected override void PlayHitSE(int actionId, Vector3 hitPos, bool isCritical, bool isLethal, CharacterBase damagedChara)
		{
		}

		protected override void PlayHitCameraShake(CameraController.ShakeType shakeType)
		{
		}

		public bool IsServantAI(ServantAIType aiType)
		{
			return default(bool);
		}

		public void ClearServantAction()
		{
		}

		public void AddServantAction(ServantActionCommand commandId)
		{
		}

		public bool UpdateServantAction()
		{
			return default(bool);
		}

		private bool RunServantAction(int actionId, ServantActionCommand commandId)
		{
			return default(bool);
		}

		private CommonObjectStatus GetServantTarget()
		{
			return null;
		}

		private void SetServantFollowPosition()
		{
		}

		public override void CallbackHitAction(CollisionHitAttribute attr)
		{
		}

		public override void RecoverySpOnHit(CollisionHitAttribute attr, float recoverySPrate, float addtionalRate)
		{
		}

		private bool IsEnableRecoverySp()
		{
			return default(bool);
		}

		public int GetNeedSp(SkillDataElement sde, int level)
		{
			return default(int);
		}

		public override int GetOverChargeSp(int skillIndex, int phase)
		{
			return default(int);
		}

		public override void CheckTransSkill(CollisionHitAttribute attr)
		{
		}

		private void CheckTransSkill(CollisionHitAttribute attr, int idx)
		{
		}

		public override void CheckTransOverChargeSkill(int skillIndex)
		{
		}

		public int GetOverChargePhase(int sp, int skillIndex)
		{
			return default(int);
		}

		public override void TransformSkillForSkillId(int skillId)
		{
		}

		public override void ResetTransSkill(int skillId)
		{
		}

		public override void DisableTrans(int skillIndex)
		{
		}

		public override bool IsPauseTransBuff(int skillId)
		{
			return default(bool);
		}

		public override void PauseTransBuff(int skillIndex, bool pause)
		{
		}

		public override bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0)
		{
			return default(bool);
		}

		public override void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate)
		{
		}

		public override void ApplyDamage(CharacterDamageIntermediate intermediate)
		{
		}

		public override bool ApplyDragonTimerSlipDamage(int damage, bool isFollower, CharacterBuffType buffType, int buffIconId, float dragonTimerDamageFromMulti = 0f)
		{
			return default(bool);
		}

		protected override DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage)
		{
			return default(DamageReaction);
		}

		protected override void Freeze()
		{
		}

		public override bool CheckParalysis(CharacterBase attacker, int slipDamage)
		{
			return default(bool);
		}

		protected override bool Paralysis(int slipDamage, bool isFollower)
		{
			return default(bool);
		}

		protected override void Swoon()
		{
		}

		protected override bool IsSuperArmor()
		{
			return default(bool);
		}

		protected override bool IsResistBlast()
		{
			return default(bool);
		}

		protected override bool IsTurnToDamageDir(DamageReaction reaction)
		{
			return default(bool);
		}

		public override bool IsTransformDragon()
		{
			return default(bool);
		}

		public override bool IsEnhanceDragon()
		{
			return default(bool);
		}

		public override bool IsServant()
		{
			return default(bool);
		}

		public override bool IsServitor()
		{
			return default(bool);
		}

		public override void RunDragonTransform()
		{
		}

		public bool RunFinalAttackAction()
		{
			return default(bool);
		}

		public override bool IsFinalAttack(int skillIndex)
		{
			return default(bool);
		}

		public override CharacterBase GetOriginalChara()
		{
			return null;
		}

		public override CharacterBase GetDragonChara()
		{
			return null;
		}

		public CharacterBase GetContractor()
		{
			return null;
		}

		public override void ResetEnhancedBurstAttackId()
		{
		}

		public override int GetEnhancedBurstAttackId()
		{
			return default(int);
		}

		public override int GetActualEnhancedBurstAttackId()
		{
			return default(int);
		}

		public override int GetEnhancedSkillIndex(int skillId)
		{
			return default(int);
		}

		public override void SetEnhancedBurstAttackId(int actionId, int modifyChargeLevel)
		{
		}

		public override void SetupEnhancedSkill(int enhancedIndex, int enhancedId, int skillId)
		{
		}

		public override void ResetEnhancedSkill(CharacterBuffType buffType, int conditionId)
		{
		}

		public override void ResetEnhancedSkill(int skillIndex)
		{
		}

		public override void SetModeChangeForStackBuff(int stackNum)
		{
		}

		public override void RecoveryHpPotion(int value, bool dispUi, bool dispEffect, bool forcibly)
		{
		}

		public override void RecoverySpRatio(float ratio, int index, bool isHumanOnly, bool isDragonOnly)
		{
		}

		public void SetDragonTimer(float time)
		{
		}

		public void AddDragonTimer(float time, bool isDamage)
		{
		}

		public override void SetIsPauseDragonTime(bool isPause)
		{
		}

		public override bool IsPauseDragonTime()
		{
			return default(bool);
		}

		public override ApplyAbnormalStatusResult CheckAbnormalStatus(CollisionHitAttribute attr, int damage, DamageReaction reaction)
		{
			return default(ApplyAbnormalStatusResult);
		}

		public override string GetFacePath()
		{
			return null;
		}

		public override int GetFaceID()
		{
			return default(int);
		}

		private float GetMaxDragonTime()
		{
			return default(float);
		}

		public override float GetOriginalDragonTime()
		{
			return default(float);
		}

		public override void RecoveryDpByPercentage(CollisionHitAttribute attr)
		{
		}

		public override void RecoveryUtpOnHit(CollisionHitAttribute attr)
		{
		}

		public override void RecoveryUtp(int point)
		{
		}

		public override void RefreshDashSpeedRatio()
		{
		}

		public override Vector3 AuraScale(bool isDynamicScale = false)
		{
			return default(Vector3);
		}

		private CharacterBase CheckCurrentCharaIsActiveInHierarchy()
		{
			return null;
		}

		public override float GetSearchRange()
		{
			return default(float);
		}
	}
}
