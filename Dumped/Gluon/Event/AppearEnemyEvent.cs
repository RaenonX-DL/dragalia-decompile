using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class AppearEnemyEvent : EventBase<AppearEnemyEvent>
	{
		[Key(1)]
		public int taskId;

		[Required]
		[Key(2)]
		public CharacterId owner;

		[Required]
		[Key(3)]
		public CharacterId popEnemy;

		[Key(4)]
		public CharacterId target;

		[Key(5)]
		public Vector3 popPos;

		[Key(6)]
		public Quaternion popRot;

		[Key(7)]
		public int childActionid;

		[Key(8)]
		public byte flags;
	}
}
