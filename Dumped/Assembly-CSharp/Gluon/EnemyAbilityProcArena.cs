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
	public class EnemyAbilityProcArena : EnemyAbilityProcBase
	{
		// Fields
		private float sqrRadius;
	
		// Constructors
		public EnemyAbilityProcArena(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref EnemyAbility.Argument arg);
		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg);
		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg);
	}
}
