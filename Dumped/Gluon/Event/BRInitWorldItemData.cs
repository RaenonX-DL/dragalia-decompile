using System.Runtime.InteropServices;
using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[StructLayout(0, Size = 24)]
	[MessagePackObject(false)]
	public struct BRInitWorldItemData
	{
		[Key(0)]
		public Vector3 point;

		[Key(1)]
		public BRItemParam item;
	}
}
