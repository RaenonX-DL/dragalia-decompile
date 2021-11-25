using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class EventD00562 : EventBase<EventD00562>
	{
		[Required]
		[Key(1)]
		public CharacterId target;

		[Required]
		[Key(2)]
		public CharacterId clawEnemy;

		[Key(3)]
		public int actionId;

		[Key(4)]
		public short actionPartsIndex;

		[Key(5)]
		public Vector3 position;
	}
}
