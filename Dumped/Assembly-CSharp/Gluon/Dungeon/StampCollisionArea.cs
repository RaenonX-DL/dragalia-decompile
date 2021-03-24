/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class StampCollisionArea : MonoBehaviour
	{
		// Fields
		[EnumFlags]
		[SerializeField]
		private DirectionFlags dirFlags;
	
		// Nested types
		[Flags]
		public enum DirectionFlags
		{
			Down = 1,
			Up = 2,
			Left = 4,
			Right = 8
		}
	
		// Constructors
		public StampCollisionArea();
	
		// Methods
		public bool IsDirectionFlags(DirectionFlags f);
	}
}
