using Gluon.Event;

namespace Gluon
{
	public class EnemyEventSender : EventSenderBase
	{
		private EnemyCharacter enemy;

		private EnemyCtrl enemyCtrl;

		public override CharacterBase character => null;

		public override void Initialize(CharacterId characterId, bool useMoveBundle = false)
		{
		}

		protected override bool IsAiAwake()
		{
			return default(bool);
		}
	}
}
