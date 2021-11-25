using System.Collections.Generic;
using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRCreateItemEvent : EventBase<BRCreateItemEvent>
	{
		public enum PatternTypes
		{
			RandomPop,
			Silent
		}

		[Key(1)]
		public Vector3 pos;

		[Key(2)]
		public float radius;

		[Key(3)]
		public uint seed;

		[Key(4)]
		public List<BRItemParam> items;

		[Key(5)]
		public PatternTypes pattern;
	}
}
