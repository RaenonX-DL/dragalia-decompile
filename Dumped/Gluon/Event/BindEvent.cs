using System.Collections.Generic;
using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BindEvent : EventBase<BindEvent>
	{
		public enum Types
		{
			Catch,
			Confirm,
			Release
		}

		[Key(1)]
		public Types eventType;

		[Key(2)]
		public long bindEventId;

		[Key(3)]
		public CharacterId owner;

		[Key(4)]
		public List<CharacterId> targets;

		[Key(5)]
		public Vector3 position;

		[Key(6)]
		public byte flags;

		[Key(7)]
		public byte effectTrigger;
	}
}
