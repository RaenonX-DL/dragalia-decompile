/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RoomEntryCondition
	{
		// Fields
		[Key]
		public HashSet<ElementalType> unacceptedElementals;
		[Key]
		public HashSet<WeaponType> unacceptedWeapons;
		[Key]
		public int requiredPower;
		[Key]
		public Objective objective;
	
		// Nested types
		[MessagePackObject]
		public struct Objective
		{
			// Fields
			[Key]
			public int textId;
	
			// Methods
			public static Objective GetEmptyObjective();
			public bool IsEmpty();
		}
	
		// Constructors
		public RoomEntryCondition();
		public RoomEntryCondition(RoomEntryCondition c);
	
		// Methods
		public static RoomEntryCondition Anyone();
	}
}
