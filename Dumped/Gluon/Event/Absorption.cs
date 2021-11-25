using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Absorption : KnockBack
	{
		[Key(3)]
		public Vector3 collisionPos;
	}
}
