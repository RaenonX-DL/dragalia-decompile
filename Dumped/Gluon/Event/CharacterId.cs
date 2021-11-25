using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterId
	{
		[Key(0)]
		public short actorId;

		[Key(1)]
		public short index;

		public const int ServantIndexOffset = 20;

		public const int LatterPartyIndexOffset = 40;

		public const int GuestPlayerIndexOffset = 100;

		public bool IsSame(CharacterId id)
		{
			return default(bool);
		}

		public static CharacterId GetPlayerCharacterId(int partySwitchIndex, int actorId, int index, bool isServant = false, bool isGuest = false)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public int GetPartySwitchIndex()
		{
			return default(int);
		}
	}
}
