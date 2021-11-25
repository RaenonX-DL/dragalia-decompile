using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBookOfDoom : EnemyAbilityProcBase
	{
		private bool _hasBoost;

		private bool _hasPlayed;

		private const float RESTART_TIME = 5f;

		private float _timer;

		private bool _isExtinctionActionReserved;

		private bool _isExtinctionAactionSyncd;

		private int _isSubCountReserved;

		public int count
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

		private bool isWaitActionForExtraAction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EnemyAbilityProcBookOfDoom(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Setup()
		{
		}

		public override void Stop()
		{
		}

		public override void OnUpdate()
		{
		}

		public void SubCount(int point, EnemyCharacter deadEnemy, bool isSync)
		{
		}

		private bool CheckWaitAction()
		{
			return default(bool);
		}

		private void PlayAction()
		{
		}

		public override void OnRecieveCharacterState(CharacterState characterState)
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
