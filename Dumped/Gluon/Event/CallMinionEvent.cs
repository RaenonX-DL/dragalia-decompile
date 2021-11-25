using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CallMinionEvent : EventBase<CallMinionEvent>
	{
		[Key(1)]
		public int taskId;

		[Required]
		[Key(2)]
		public CharacterId caller;

		[Required]
		[Key(3)]
		public string label;

		[Key(4)]
		public int baseType;

		[Key(5)]
		public Vector3 position;

		[Key(6)]
		public bool editDirection;

		[Key(7)]
		public Quaternion rotation;

		[Key(8)]
		public float areaRadius;

		[Key(9)]
		public uint randomSeed;
	}
}
