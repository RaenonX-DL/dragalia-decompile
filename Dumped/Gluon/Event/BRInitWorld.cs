using System.Collections.Generic;
using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRInitWorld : EventBase<BRInitWorld>
	{
		[Key(1)]
		public Vector3 pulseCenterPoint;

		[Key(2)]
		public List<BRInitWorldItemData> items;

		[Key(3)]
		public float pulseMaxRadius;
	}
}
