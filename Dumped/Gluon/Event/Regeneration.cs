using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Regeneration : EventBase<Regeneration>
	{
		[Required]
		[Key(1)]
		public CharacterId target;

		[Key(2)]
		public short type;

		[Required]
		[Key(3)]
		public int[] healValues;

		[Key(4)]
		public Dictionary<CharacterId, int> froms;

		[Key(5)]
		public int damageValue;

		[Key(6)]
		public bool isFollower;

		[Key(7)]
		public int uniqueIconType;

		[Key(8)]
		public float dragonTimerDamage;

		[Key(9)]
		public int buffIconId;
	}
}
