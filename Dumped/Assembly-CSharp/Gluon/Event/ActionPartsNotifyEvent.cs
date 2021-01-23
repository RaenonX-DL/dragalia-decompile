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
	public class ActionPartsNotifyEvent : EventBase<ActionPartsNotifyEvent>
	{
		// Fields
		[Key]
		[Required]
		public ActionPartsNotifyEventTypes type;
		[Key]
		[Required]
		public CharacterId target;
		[Key]
		public ActionPartsNotifyEventParamBase param;
	
		// Nested types
		public enum ActionPartsNotifyEventTypes
		{
			GozTackleInit = 0,
			GozTackleTarget = 1
		}
	
		// Constructors
		public ActionPartsNotifyEvent();
	}
}
