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
	public class DropPrayObjectDungeonObject : DungeonObjectParameterBase
	{
		// Fields
		[Key]
		public Vector3 position;
		[Key]
		public DropPrayObjectEventType type;
		[Key]
		public int dropPrayObjectindex;
		[Key]
		public CharacterId characterId;
		[Key]
		public Quaternion rotation;
		[Key]
		public bool showMarker;
		[Key]
		public CharacterId markerOwner;
		[Key]
		public float lifeTime;
	
		// Nested types
		public enum DropPrayObjectEventType
		{
			Set = 0,
			Hit = 1
		}
	
		// Constructors
		public DropPrayObjectDungeonObject();
	}
}
