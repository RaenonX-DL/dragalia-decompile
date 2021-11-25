using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BarrelBombDungeonObject : DungeonObjectParameterBase
	{
		public enum BarrelEventType
		{
			Set,
			Explosion
		}

		[Key(0)]
		public Vector3 position;

		[Key(1)]
		public BarrelEventType type;

		[Key(2)]
		public int explosionCounterFromMulti;

		[Key(3)]
		public int barrelBombindex;
	}
}
