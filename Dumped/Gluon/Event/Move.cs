using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Move : EventBase<Move>
	{
		[Key(1)]
		public CharacterId characterId;

		[Key(2)]
		public Vector3 position;

		[Key(3)]
		public float rotation;

		[Key(4)]
		public byte flags;

		[Key(5)]
		public int moveEventTimestamp;
	}
}
