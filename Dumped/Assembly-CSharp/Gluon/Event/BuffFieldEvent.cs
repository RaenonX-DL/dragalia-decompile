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
	public class BuffFieldEvent : EventBase<BuffFieldEvent>
	{
		// Fields
		[Key]
		[Required]
		public BuffFieldEventTypes type;
		[Key]
		[Required]
		public long buffFieldId;
		[Key]
		[Required]
		public CharacterId owner;
		[Key]
		public BuffFieldEventParamBase param;
	
		// Nested types
		public enum BuffFieldEventTypes
		{
			Create = 0,
			Delete = 1
		}
	
		// Constructors
		public BuffFieldEvent();
	}
}
