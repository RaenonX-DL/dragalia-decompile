/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class Statistics : EventBase<Statistics>
	{
		// Fields
		[Key]
		public int roundTripTime;
		[Key]
		public int roundTripTimeVariance;
		[Key]
		public float incommingByteCountPerSec;
		[Key]
		public float outgoingByteCountPerSec;
		[Key]
		public int maxQueuedIncommingCommands;
		[Key]
		public int maxQueuedOutgoingCommands;
	
		// Constructors
		public Statistics();
	}
}
