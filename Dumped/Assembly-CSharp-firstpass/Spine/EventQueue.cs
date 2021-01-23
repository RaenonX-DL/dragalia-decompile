/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	internal class EventQueue
	{
		// Fields
		private readonly List<EventQueueEntry> eventQueueEntries;
		internal bool drainDisabled;
		private readonly AnimationState state;
		private readonly Pool<TrackEntry> trackEntryPool;
		[CompilerGenerated]
		private Action AnimationsChanged;
	
		// Events
		internal event Action AnimationsChanged {
			add;
			remove;
		}
	
		// Nested types
		private struct EventQueueEntry
		{
			// Fields
			public EventType type;
			public TrackEntry entry;
			public Event e;
	
			// Constructors
			public EventQueueEntry(EventType eventType, TrackEntry trackEntry, Event e = null);
		}
	
		private enum EventType
		{
			Start = 0,
			Interrupt = 1,
			End = 2,
			Dispose = 3,
			Complete = 4,
			Event = 5
		}
	
		// Constructors
		internal EventQueue(AnimationState state, Action HandleAnimationsChanged, Pool<TrackEntry> trackEntryPool);
	
		// Methods
		internal void Start(TrackEntry entry);
		internal void Interrupt(TrackEntry entry);
		internal void End(TrackEntry entry);
		internal void Dispose(TrackEntry entry);
		internal void Complete(TrackEntry entry);
		internal void Event(TrackEntry entry, Event e);
		internal void Drain();
		internal void Clear();
	}
}
