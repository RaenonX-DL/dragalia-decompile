using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class KnockBack
	{
		[Key(0)]
		public Vector3 direction;

		[Key(1)]
		public float distance;

		[Key(2)]
		public float duration;
	}
}
