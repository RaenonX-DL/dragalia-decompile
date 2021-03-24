/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterMoveEventClock
	{
		// Fields
		private CharacterBase _owner;
		private int _nextOwnSequenceNum;
		private Timestamp _current;
	
		// Properties
		public Timestamp current { get; }
	
		// Nested types
		public class Timestamp
		{
			// Fields
			public static readonly int MaxSequenceNum;
			public int actorId;
			public int sequenceNum;
	
			// Constructors
			public Timestamp(Timestamp ts);
			public Timestamp(int actorId, int sequenceNum);
			static Timestamp();
	
			// Methods
			public static int Serialize(Timestamp ts);
			public static Timestamp Deserialize(int value);
			public bool IsHappenedBefore(Timestamp ts);
		}
	
		// Constructors
		public CharacterMoveEventClock();
	
		// Methods
		public Timestamp Advance();
		public void SetTimestamp(Timestamp ts);
		public bool IsHappenedBefore(Timestamp ts);
		private int GetOwnActorId();
	}
}
