using System.Runtime.CompilerServices;
using Gluon.Event;

namespace Gluon
{
	public class EnemyEventReceiver : EventReceiverBase
	{
		private EnemyCtrl enemyCtrl;

		public override CharacterBase character => null;

		public EnemyCharacter enemy
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void Initialize(CharacterId characterId)
		{
		}

		protected override void ChangeStateImpl(CharacterState characterState)
		{
		}

		public void DenyGuard(DenyGuard denyGuard)
		{
		}
	}
}
