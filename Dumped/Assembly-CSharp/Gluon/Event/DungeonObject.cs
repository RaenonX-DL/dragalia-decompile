﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class DungeonObject : EventBase<DungeonObject>
	{
		// Fields
		[Key]
		public int serialNumber;
		[Key]
		public int randomSeed;
		[Key]
		public long scheduledTime;
		[Key]
		public CharacterId characterId;
		[Key]
		public DungeonObjectParameterBase param;
	
		// Constructors
		public DungeonObject();
	}
}
