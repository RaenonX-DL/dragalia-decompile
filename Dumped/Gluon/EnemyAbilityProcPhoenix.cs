using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityProcPhoenix : EnemyAbilityProcBase, ICollideCallback
	{
		private CollisionHitAttribute _counterHitAttribute;

		private CollisionHitAttribute _healHitAttribute;

		private List<CharacterBase> _counterTarget;

		private EnemyAbilityHeadGaugeUI gaugeUI;

		private float _timer;

		private bool _isHealHitting;

		private int _wallHp;

		private bool _hasReservedWallStop;

		private const int DESTROY_EFF_TRIG = 9;

		public int wallHp
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public int wallMaxHp => default(int);

		public float wallHpRate => default(float);

		public bool isWallMode
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

		public bool isExtraBuff => default(bool);

		public EnemyAbilityProcPhoenix(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
		{
		}

		public override void OnUpdate()
		{
		}

		private void OnDamageEvent(CollisionHitAttribute attr, int damage)
		{
		}

		public override void OnApplyBuffDebuffVarious(CharacterBuffType buffType, bool isBuff, CharacterBase from, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnAbnormalStatusProbability(int type, float probability, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnDispel(ref EnemyAbility.Argument arg)
		{
		}

		public void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public override void CreateCharacterMarkRelationUI()
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
