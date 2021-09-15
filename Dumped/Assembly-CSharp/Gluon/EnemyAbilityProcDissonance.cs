/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcDissonance : EnemyAbilityProcBase, ICollideCallback
	{
		// Fields
		private CollisionHitAttribute _hitAttribute;
		private List<CharacterBase> _counterTarget;
		[CompilerGenerated]
		private readonly List<CounterInfo> _listCounterInfo_k__BackingField;
	
		// Properties
		private List<CounterInfo> listCounterInfo { [CompilerGenerated] get; }
		public bool isDissonanceBuff { get; }
	
		// Nested types
		private class CounterInfo
		{
			// Fields
			public CharacterBase chara;
			public int skillId;
			public int skillProductId;
	
			// Constructors
			public CounterInfo();
		}
	
		// Constructors
		public EnemyAbilityProcDissonance(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void Stop();
		public override void OnUpdate();
		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg);
		public override void OnCalcBaseDamageReceive(CollisionHitAttribute hitAttr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg);
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
	}
}
