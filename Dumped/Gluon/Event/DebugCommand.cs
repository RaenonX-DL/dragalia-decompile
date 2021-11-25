using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebugCommand : EventBase<DebugCommand>
	{
		public enum DebugCommandTypes
		{
			None,
			QuestClear,
			BRWarp,
			KillingEnemy,
			EnemyParameterMaxHP,
			EnemyParameterATK,
			EnemyParameterOD,
			EnemyParameterBreak
		}

		[Required]
		[Key(1)]
		public DebugCommandTypes type;

		[Key(2)]
		public bool boolValue;

		[Key(3)]
		public int intValue;

		[Key(4)]
		public float floatValue;

		[Required]
		[Key(5)]
		public CharacterId charaId;
	}
}
