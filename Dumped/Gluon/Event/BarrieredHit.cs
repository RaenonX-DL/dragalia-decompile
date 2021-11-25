using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BarrieredHit : EventBase<BarrieredHit>
	{
		[Key(1)]
		public CharacterId targetEnemy;

		[Key(2)]
		public int from;

		[ActionId]
		[Key(3)]
		public int actionId;

		[Key(4)]
		public Vector3 hitPos;

		[Key(5)]
		public bool isFromAdditionalAttack;
	}
}
