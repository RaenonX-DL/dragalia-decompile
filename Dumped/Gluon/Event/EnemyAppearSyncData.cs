using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct EnemyAppearSyncData
	{
		[Required]
		[Key(0)]
		public CharacterId character;

		[EnemyParamId]
		[Key(1)]
		public int paramId;
	}
}
