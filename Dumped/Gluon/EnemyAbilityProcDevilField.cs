using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcDevilField : EnemyAbilityProcBase
	{
		private enum FieldType
		{
			Devil,
			Angel
		}

		private enum State
		{
			Inactive,
			OnActive,
			Active,
			Burst
		}

		private State _state;

		private float _sqrRange;

		private float _timer;

		private CollisionHitAttribute _hitAttribute;

		private int _baseFixedDamage;

		public const int INACTIVE_EFF_TRIG = 9;

		private bool _isPartySwitching;

		private float _timeLeftPrePartySwitch;

		public int activeCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int burstCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override string effKey => null;

		public EnemyAbilityProcDevilField(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Play()
		{
		}

		public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg)
		{
		}

		private void ProcOnActive()
		{
		}

		private void ProcBurst(bool isSync, bool canSubCount)
		{
		}

		private void ProcBurstInDevil(bool canSubCount, bool fromOtherPlayer)
		{
		}

		private void ProcBurstInAbgel(bool canSubCount, bool fromOtherPlayer)
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}

		private bool CheckPartySwitch()
		{
			return default(bool);
		}
	}
}
