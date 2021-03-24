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
	public class FailQuestResponse : EventBase<FailQuestResponse>
	{
		// Fields
		[Key]
		[Required]
		public ResultTypes resultType;
	
		// Nested types
		public enum ResultTypes
		{
			Timeup = 0,
			Clear = 1
		}
	
		// Constructors
		public FailQuestResponse();
	}
}
