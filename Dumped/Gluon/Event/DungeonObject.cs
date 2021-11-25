using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DungeonObject : EventBase<DungeonObject>
	{
		[Key(1)]
		public int serialNumber;

		[Key(2)]
		public int randomSeed;

		[Key(3)]
		public long scheduledTime;

		[Key(4)]
		public CharacterId characterId;

		[Key(5)]
		public DungeonObjectParameterBase param;
	}
}
