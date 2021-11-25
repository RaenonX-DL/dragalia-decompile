using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RecoveryHpRequest : EventBase<RecoveryHpRequest>
	{
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public CharacterId from;

		[Key(3)]
		public int healValue;

		[Key(4)]
		public byte characterType;

		[Key(5)]
		public short elementIndex;

		[Key(6)]
		public int actionId;

		[Key(7)]
		public int productId;

		[Key(8)]
		public int bulletId;

		[Key(9)]
		public int skillId;

		[Key(10)]
		public int followerAvoid;
	}
}
