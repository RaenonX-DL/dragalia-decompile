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
	public class FailQuestRequest : EventBase<FailQuestRequest>
	{
		// Fields
		[Key]
		[Required]
		public FailTypes failType;
	
		// Nested types
		public enum FailTypes
		{
			Timeup = 0,
			AllDead = 1
		}
	
		// Constructors
		public FailQuestRequest();
	}
}
