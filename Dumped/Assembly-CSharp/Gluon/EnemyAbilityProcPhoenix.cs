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
	public class EnemyAbilityProcPhoenix : EnemyAbilityProcBase, ICollideCallback
	{
		// Fields
		private CollisionHitAttribute _counterHitAttribute;
		private CollisionHitAttribute _healHitAttribute;
		private List<CharacterBase> _counterTarget;
		private EnemyAbilityHeadGaugeUI gaugeUI;
		private float _timer;
		private bool _isHealHitting;
		private int _wallHp;
		[CompilerGenerated]
		private bool _isWallMode_k__BackingField;
		private bool _hasReservedWallStop;
		private const int DESTROY_EFF_TRIG = 9;
	
		// Properties
		public int wallHp { get; private set; }
		public int wallMaxHp { get; }
		public float wallHpRate { get; }
		public bool isWallMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isExtraBuff { get; }
	
		// Constructors
		public EnemyAbilityProcPhoenix(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void Play();
		public override void Stop();
		public override void OnUpdate();
		private void OnDamageEvent(CollisionHitAttribute attr, int damage);
		public override void OnApplyBuffDebuffVarious(CharacterBuffType buffType, bool isBuff, CharacterBase from, ref Gluon.EnemyAbility.Argument arg);
		public override void OnAbnormalStatusProbability(int type, float probability, ref Gluon.EnemyAbility.Argument arg);
		public override void OnDispel(ref Gluon.EnemyAbility.Argument arg);
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		public override void CreateCharacterMarkRelationUI();
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
