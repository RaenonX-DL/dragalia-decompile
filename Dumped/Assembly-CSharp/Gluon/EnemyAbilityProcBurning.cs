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
	public class EnemyAbilityProcBurning : EnemyAbilityProcBase
	{
		// Fields
		[CompilerGenerated]
		private int _count_k__BackingField;
		private EnemyAbilityProcPhoenix _phoenix;
		private int _burningResetCount;
		private Dictionary<int, int> _burningCountReservedMap;
		private bool _isPlayReserved;
		private bool _isPlayReceived;
	
		// Properties
		public int count { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public EnemyAbilityProcBurning(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		private void OnPlay(int burningCount);
		public override void Stop();
		public override void OnUpdate();
		public override void OnAbnormalStatusProbability(int type, float probability, ref Gluon.EnemyAbility.Argument arg);
		public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref Gluon.EnemyAbility.Argument arg);
		public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref Gluon.EnemyAbility.Argument arg);
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
		private int AddBurningResetCount();
		public override void OnRecieveCharacterState(CharacterState recvEvent);
	}
}
