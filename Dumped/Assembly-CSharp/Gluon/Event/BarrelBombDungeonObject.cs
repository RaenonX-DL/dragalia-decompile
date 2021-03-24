/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BarrelBombDungeonObject : DungeonObjectParameterBase
	{
		// Fields
		[Key]
		public Vector3 position;
		[Key]
		public BarrelEventType type;
		[Key]
		public int explosionCounterFromMulti;
		[Key]
		public int barrelBombindex;
	
		// Nested types
		public enum BarrelEventType
		{
			Set = 0,
			Explosion = 1
		}
	
		// Constructors
		public BarrelBombDungeonObject();
	}
}
