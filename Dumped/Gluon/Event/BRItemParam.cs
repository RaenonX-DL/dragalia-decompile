using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct BRItemParam
	{
		[Key(0)]
		public BRItemId id;

		[Key(1)]
		public BattleRoyalDungeonItem type;
	}
}
