using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class AreaTrapDungeonObject : DungeonObjectParameterBase
	{
		public enum AreaTrapEventType
		{
			Set
		}

		[Key(0)]
		public Vector3 position;

		[Key(1)]
		public AreaTrapEventType type;

		[Key(2)]
		public int areaTrapBombindex;
	}
}
