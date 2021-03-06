﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcBerserkBase : EnemyAbilityProcBase
	{
		// Properties
		public override bool isBerserk { get; }
	
		// Constructors
		public EnemyAbilityProcBerserkBase(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		public override void Stop();
		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND);
		public override void OnOverdrive(ref EnemyAbility.Argument arg);
		public override void OnBreakFinish();
		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg);
		public override void OnCalcModeDifense(CharacterBase attacker, ref EnemyAbility.Argument arg);
		public override void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref EnemyAbility.Argument arg);
	}
}
