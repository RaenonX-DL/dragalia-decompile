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
	public class EnemyAbilityProcDrain : EnemyAbilityProcBase
	{
		// Fields
		private bool _reserveInfection;
		public List<CharacterBase> _drainTargets;
		private const float INFECTION_DELAY = 0.5f;
		private float _infectionTimer;
	
		// Constructors
		public EnemyAbilityProcDrain(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void OnUpdate();
		public override void OnDrain(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Gluon.EnemyAbility.Argument arg);
		private void ProcVirus(CharacterBase receiver, CollisionHitAttribute hitAttr, ref Gluon.EnemyAbility.Argument arg);
		public override void OnPostDrain();
		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr);
		public override void OnFollowerAvoid(CharacterBase receiver);
		private void Infection();
		private void PlayDrainDirection(CharacterBase receiver);
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
