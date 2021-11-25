using System;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class StampCollisionArea : MonoBehaviour
	{
		[Flags]
		public enum DirectionFlags
		{
			Down = 0x1,
			Up = 0x2,
			Left = 0x4,
			Right = 0x8
		}

		[SerializeField]
		[EnumFlags]
		private DirectionFlags dirFlags;

		public bool IsDirectionFlags(DirectionFlags f)
		{
			return default(bool);
		}
	}
}
