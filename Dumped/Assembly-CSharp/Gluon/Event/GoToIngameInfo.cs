/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class GoToIngameInfo
	{
		// Fields
		[Key]
		public List<ActorData> elements;
		[Key]
		public BRInitData brInitData;
	
		// Nested types
		[MessagePackObject]
		public class ActorData
		{
			// Fields
			[Key]
			public int ActorId;
			[Key]
			public ulong ViewerId;
	
			// Constructors
			public ActorData();
		}
	
		[MessagePackObject]
		public class BRInitData
		{
			// Fields
			[Key]
			public int locationPattern;
			[Key]
			public List<int> playerPositions;
			[Key]
			public string multiPlayKey;
	
			// Constructors
			public BRInitData();
		}
	
		// Constructors
		public GoToIngameInfo();
	}
}
