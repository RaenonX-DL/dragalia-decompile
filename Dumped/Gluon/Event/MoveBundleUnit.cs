using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class MoveBundleUnit
	{
		[Key(0)]
		public CharacterId characterId;

		[Key(1)]
		public Vector3 position;

		[Key(2)]
		public float rotation;

		[Key(3)]
		public byte flags;
	}
}
