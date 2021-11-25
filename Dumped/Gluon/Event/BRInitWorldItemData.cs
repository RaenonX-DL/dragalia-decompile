using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct BRInitWorldItemData
	{
		[Key(0)]
		public Vector3 point;

		[Key(1)]
		public BRItemParam item;
	}
}
