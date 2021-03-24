/*
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
	public class WillLeave : EventBase<WillLeave>
	{
		// Fields
		[Key]
		public Reasons reason;
	
		// Nested types
		public enum Reasons
		{
			None = 0,
			Retire = 1,
			LeaveAlone = 2,
			BRContinueRetire = 3
		}
	
		// Constructors
		public WillLeave();
	}
}
