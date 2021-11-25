using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Charge : EventBase<Charge>
	{
		[Required]
		[Key(1)]
		public CharacterId characterId;

		[Key(2)]
		public float rotation;

		[Key(3)]
		public float pullLength;

		[Key(4)]
		public Vector3 markerPos;
	}
}
