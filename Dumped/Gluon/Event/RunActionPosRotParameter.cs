using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionPosRotParameter : RunActionParameterBase
	{
		[Key(0)]
		public Vector3 position;

		[Key(1)]
		public float rotation;
	}
}
