/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcPowerCrystal : EnemyAbilityProcBase
	{
		// Fields
		[CompilerGenerated]
		private ConditionType _conditionType_k__BackingField;
		private ConditionType _reservedCondition;
		private const string SURGE_MESH_NAME = "mRockA";
		private const string DORMANT_MESH_NAME = "mRockB";
		private const string FRAGILE_MESH_NAME = "mRockC";
		private Transform _surgeMesh;
		private Transform _dormantMesh;
		private Transform _fragileMesh;
		private bool _isExplosion;
		private bool _hasCharge;
		private float _timer;
		private CollisionHitAttribute _hitAttribute;
		private const string EFF_DANGER_ZONE = "EFF_BOS_HBS_0130101_011";
		private const string EFF_EXPLOSION = "EFF_BOS_HBS_0130101_008";
		private const string EFF_LEAVE = "EFF_BOS_HBS_0130101_009";
		private const string EFF_TRANSITION = "EFF_BOS_HBS_0130101_010";
		private EffectObject _eoDangerZone;
		private const string SE_TRANS_SURGE = "SE_ENE_HBS_0130101_01_0002";
		private const string SE_CRITICALITY = "SE_ENE_HBS_0130101_01_0003";
		private const string SE_EXPLOSION = "SE_ENE_HBS_0130101_01_0004";
	
		// Properties
		public ConditionType conditionType { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum ConditionType
		{
			Surge = 0,
			Dormant = 1,
			Fragile = 2
		}
	
		private enum DangerZoneVisibleTiming
		{
			None = 0,
			Always = 1,
			InSurge = 2,
			Criticality = 3
		}
	
		// Constructors
		public EnemyAbilityProcPowerCrystal(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void Play();
		public override void Stop();
		public override void OnCharacterDead();
		public override void OnCharacterLeave();
		public override void OnUpdate();
		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg);
		public override void OnDamage(CollisionHitAttribute attr, int damage);
		public override void OnFatalAttack(ref EnemyAbility.Argument arg);
		private void SwitchCondition();
		private void SetVisibleAllMesh(bool onoff);
		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND);
		private EffectObject PlayEffect2(string effName, int effTrigger = 8);
		public void StopEffect2(ref EffectObject eo);
	}
}
