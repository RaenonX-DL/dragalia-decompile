using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcBookOfGenesis : EnemyAbilityProcBase
	{
		private EnemyCharacter _book;

		private bool _hasBook;

		private EnemyCharacter _linked;

		private bool _isPlayReserved;

		private bool _isStopReserved;

		private bool _isAppliedBuff;

		public int linkedId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isPlayed
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

		public EnemyAbilityProcBookOfGenesis(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		private void SetBook()
		{
		}

		public override void Play()
		{
		}

		private void OnPlay()
		{
		}

		public override void Stop()
		{
		}

		private void OnStop()
		{
		}

		public override void OnUpdate()
		{
		}

		private void RegisterLinkedEnemy()
		{
		}

		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
		{
		}
	}
}
