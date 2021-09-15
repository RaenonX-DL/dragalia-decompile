/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonCharacter : PlayerCharacter
	{
		// Fields
		private HumanCharacter _human;
		[CompilerGenerated]
		private DragonData _dragonData_k__BackingField;
		[CompilerGenerated]
		private float _dragonTimer_k__BackingField;
		[CompilerGenerated]
		private float _maxDragonTimer_k__BackingField;
		[CompilerGenerated]
		private bool _isServant_k__BackingField;
		[CompilerGenerated]
		private bool _isDragonMode2_k__BackingField;
		private bool isPauseDragonTime;
		[CompilerGenerated]
		private bool _isReleaseTransformForDamaged_k__BackingField;
		[CompilerGenerated]
		private bool _isEnhanceModeEnd_k__BackingField;
		[CompilerGenerated]
		private int _skillUseNum_k__BackingField;
		public static readonly float dragonFlashingTime;
		private ServantAIType servantAIType;
		[CompilerGenerated]
		private List<SearvantActionData> _servantActions_k__BackingField;
		[CompilerGenerated]
		private Vector3 _servantFollowPosition_k__BackingField;
	
		// Properties
		public override FollowerAIBase followerAI { get; }
		public override string DebugName { get; }
		public HumanCharacter human { get; }
		public DragonData dragonData { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float dragonTimer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float maxDragonTimer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float dragonTimerRate { get; }
		public bool isServant { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isDragonMode2 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isReleaseTransformForDamaged { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isEnhanceModeEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int skillUseNum { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<SearvantActionData> servantActions { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 servantFollowPosition { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum ServantAIType
		{
			Normal = 0,
			CommandWait = 1
		}
	
		public enum ServantActionCommand
		{
			None = 0,
			Combo1 = 1,
			Combo2 = 2,
			Combo3 = 3,
			Combo4 = 4,
			Combo5 = 5,
			Skill1 = 6,
			Skill2 = 7
		}
	
		public struct SearvantActionData
		{
			// Fields
			public ServantActionCommand commandId;
			public int actionId;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public DragonCharacter dragon;
			public int dragonId;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _Create_b__0(CharacterAnimationEvent animEvent);
		}
	
		// Constructors
		public DragonCharacter();
		static DragonCharacter();
	
		// Methods
		public static DragonCharacter Create(HeroParam param, HumanCharacter character, GameObject parent, int layer, bool isNeedShadow, bool isOtherPlayer, int actorIndex, CharacterManager charaManager = null);
		public override int GetSortingOrderOffset();
		public override float ShadowSize();
		public void Initialize(int characterId, int uniqueDragonId, bool isNeedShadow, int actorIndex);
		private void LoadAction(bool isOtherPlayer);
		public void AddLoadFinalAttackAction(List<int> actions);
		private void AttachDragonDecoration();
		private void AttachDragonDecoration(int decoId);
		public void SetupDragon(HumanCharacter character, HeroParam heroParam, bool isOtherPlayer);
		private void SetupDragonInActionEditor(HumanCharacter character, int dragonId, int uniqueDragonId, int dragonLv);
		private void SetupEnhanceGauge();
		public override void SetupAbilityCommonData();
		public void TakeOverStatus(HumanCharacter chara);
		public void ShareParameter(HumanCharacter chara);
		public override void ReleaseUniqueTransform(bool isCancel);
		public bool IsHpInfinity(bool ignoreCheckDragonQuest = false);
		public override void FastUpdate();
		public override void SetFaceType(FaceType type, bool force = false);
		public override void LateUpdate();
		public override int GetSkillNum();
		public override CharacterSkillData GetSkillData(int index);
		public override SkillDataElement GetSkillDataElement(int index);
		public override SkillDataElement GetTransSkillDataElement(int index, int phase);
		public override TribeType GetTribe();
		public override bool IsCombo(int actionId);
		public override int GetComboAttackId(int idx, bool ex);
		public override int GetMaxCombo();
		public override int GetDragonTransformActionId();
		public override int GetAvoidActionId(InGameDef.Direction dir);
		public override int[] GetAllAvoidActions(InGameDef.Direction dir);
		protected override float AvoidDirectionCoef(InGameDef.Direction dirType, int actionId);
		protected override void PlayHitSE(int actionId, Vector3 hitPos, bool isCritical, bool isLethal, CharacterBase damagedChara);
		protected override void PlayHitCameraShake(CameraController.ShakeType shakeType);
		public bool IsServantAI(ServantAIType aiType);
		public void ClearServantAction();
		public void AddServantAction(ServantActionCommand commandId);
		public bool UpdateServantAction();
		private bool RunServantAction(int actionId, ServantActionCommand commandId);
		private CommonObjectStatus GetServantTarget();
		private void SetServantFollowPosition();
		public override void CallbackHitAction(CollisionHitAttribute attr);
		public override void RecoverySpOnHit(CollisionHitAttribute attr, float recoverySPrate, float addtionalRate);
		private bool IsEnableRecoverySp();
		private void CheckTransSkill(CollisionHitAttribute attr, int idx);
		public override void ResetTransSkill(int skillId);
		public override bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0);
		public override void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate);
		public override void ApplyDamage(CharacterDamageIntermediate intermediate);
		public override bool ApplyDragonTimerSlipDamage(int damage, bool isFollower, CharacterBuffType buffType, int uniqueBuffIcon, float dragonTimerDamageFromMulti = 0f);
		protected override DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage);
		protected override void Freeze();
		public override bool CheckParalysis(CharacterBase attacker, int slipDamage);
		protected override bool Paralysis(int slipDamage, bool isFollower);
		protected override void Swoon();
		protected override bool IsSuperArmor();
		protected override bool IsResistBlast();
		protected override bool IsTurnToDamageDir(DamageReaction reaction);
		public override bool IsTransformDragon();
		public override bool IsEnhanceDragon();
		public override bool IsServant();
		public override void RunDragonTransform();
		public bool RunFinalAttackAction();
		public override bool IsFinalAttack(int skillIndex);
		public override CharacterBase GetOriginalChara();
		public override CharacterBase GetDragonChara();
		public override void ResetEnhancedBurstAttackId();
		public override int GetEnhancedBurstAttackId();
		public override int GetActualEnhancedBurstAttackId();
		public override int GetEnhancedSkillIndex(int skillId);
		public override void SetEnhancedBurstAttackId(int actionId, int modifyChargeLevel);
		public override void SetupEnhancedSkill(int enhancedIndex, int enhancedId, int skillId);
		public override void ResetEnhancedSkill(CharacterBuffType buffType, int conditionId);
		public override void ResetEnhancedSkill(int skillIndex);
		public override void SetModeChangeForStackBuff(int stackNum);
		public override void RecoveryHpPotion(int value, bool disp);
		public override void RecoverySpRatio(float ratio, int index, bool isHumanOnly);
		public void SetDragonTimer(float time);
		public void AddDragonTimer(float time, bool isDamage);
		public override void SetIsPauseDragonTime(bool isPause);
		public override bool IsPauseDragonTime();
		public override ApplyAbnormalStatusResult CheckAbnormalStatus(CollisionHitAttribute attr, int damage, DamageReaction reaction);
		public override string GetFacePath();
		public override int GetFaceID();
		private float GetMaxDragonTime();
		public override float GetOriginalDragonTime();
		public override void RecoveryDpByPercentage(CollisionHitAttribute attr);
		public override void RefreshDashSpeedRatio();
		public override Vector3 AuraScale(bool isDynamicScale = false);
		private CharacterBase CheckCurrentCharaIsActiveInHierarchy();
		public override float GetSearchRange();
		[CompilerGenerated]
		private void _Initialize_b__58_0(InGameTime.GameSpeed gameSpeedRate);
	}
}
