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
	public class DebugInspectionRequest : EventBase<DebugInspectionRequest>
	{
		// Fields
		[Key]
		[Required]
		public RequestTypes requestType;
	
		// Nested types
		public enum RequestTypes
		{
			IngameState = 0,
			LeaveReason = 1,
			AutoFailTimeout = 2,
			PlayQuestStartProcTime = 3
		}
	
		// Constructors
		public DebugInspectionRequest();
	}
}
