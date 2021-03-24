/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayErrorEventService
	{
		// Fields
		private List<Event> _queue;
	
		// Nested types
		public class Event
		{
			// Fields
			public Types type;
			public MultiPlayError error;
			public int disconnectedActorId;
	
			// Nested types
			public enum Types
			{
				DisconnectOtherPlayer = 0,
				DisconnectOwn = 1,
				DisableRanking = 2,
				DisableInstructorBonus = 3
			}
	
			// Constructors
			public Event();
		}
	
		// Constructors
		public MultiPlayErrorEventService();
	
		// Methods
		public bool HasEvent();
		public void Enqueue(Event e);
		public Event Dequeue();
		public bool CanProcessMultiPlayErrorEvent();
		public static Event CreateDisconnectOtherPlayerEvent(int disconnectedActorId);
		public static Event CreateDisconnectOwnEvent(MultiPlayError error);
		public static Event CreateDisableRankingEvent();
		public static Event CreateDisableInstructorBonusEvent();
	}
}
