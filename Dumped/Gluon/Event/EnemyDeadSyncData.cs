using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct EnemyDeadSyncData
	{
		[Required]
		[Key(0)]
		public CharacterId character;

		[Key(1)]
		public ushort popCount;

		[Key(2)]
		public DeadReason reason;
	}
}
