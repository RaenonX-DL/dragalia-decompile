/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcRampage : EnemyAbilityProcBase
	{
		// Fields
		private int _level;
		private int _lastSendLevel;
		private float _interval;
	
		// Constructors
		public EnemyAbilityProcRampage(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void OnUpdate();
		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref Gluon.EnemyAbility.Argument arg);
		public override void OnCalcBaseDamageAttack(CharacterBase receiver, ref Gluon.EnemyAbility.Argument arg);
		private void SendRampageLevel(int level);
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
