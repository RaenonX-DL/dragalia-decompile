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
	public class EventE02660 : EventBase<EventE02660>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId[] boundChrs;
		[Key]
		public CharacterId ownerId;
		[Key]
		public int actionId;
		[Key]
		public short actionPartsIndex;
	
		// Constructors
		public EventE02660();
	}
}
