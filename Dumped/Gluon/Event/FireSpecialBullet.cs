using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class FireSpecialBullet : EventBase<FireSpecialBullet>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public int actionProductId;

		[Key(3)]
		public Quaternion rotation;

		[Key(4)]
		public Vector3 aimingPoint;
	}
}
