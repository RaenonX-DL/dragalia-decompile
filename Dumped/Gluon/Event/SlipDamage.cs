using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class SlipDamage : EventBase<SlipDamage>
	{
		[Required]
		[Key(1)]
		public CharacterId target;

		[Key(2)]
		public short type;

		[Key(3)]
		public int damage;

		[Key(4)]
		public CharacterId attacker;

		[Key(5)]
		public bool isFollower;

		[Key(6)]
		public Dictionary<CharacterId, int> froms;
	}
}
