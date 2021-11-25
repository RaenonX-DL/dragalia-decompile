using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Dodge : EventBase<Dodge>
	{
		[Required]
		[Key(1)]
		public CharacterId owner;

		[Key(2)]
		public bool showDodge;

		[Key(3)]
		public CharacterId attacker;
	}
}
