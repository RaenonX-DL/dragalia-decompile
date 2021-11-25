using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DropPrayObjectDungeonObject : DungeonObjectParameterBase
	{
		public enum DropPrayObjectEventType
		{
			Set,
			Hit
		}

		[Key(0)]
		public Vector3 position;

		[Key(1)]
		public DropPrayObjectEventType type;

		[Key(2)]
		public int dropPrayObjectindex;

		[Key(3)]
		public CharacterId characterId;

		[Key(4)]
		public Quaternion rotation;

		[Key(5)]
		public bool showMarker;

		[Key(6)]
		public CharacterId markerOwner;

		[Key(7)]
		public float lifeTime;
	}
}
