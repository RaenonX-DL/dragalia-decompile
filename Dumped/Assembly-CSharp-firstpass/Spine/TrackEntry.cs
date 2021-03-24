/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class TrackEntry : Pool<Spine.TrackEntry>
	{
		// Fields
		internal Animation animation;
		internal TrackEntry next;
		internal TrackEntry mixingFrom;
		internal int trackIndex;
		internal bool loop;
		internal float eventThreshold;
		internal float attachmentThreshold;
		internal float drawOrderThreshold;
		internal float animationStart;
		internal float animationEnd;
		internal float animationLast;
		internal float nextAnimationLast;
		internal float delay;
		internal float trackTime;
		internal float trackLast;
		internal float nextTrackLast;
		internal float trackEnd;
		internal float timeScale;
		internal float alpha;
		internal float mixTime;
		internal float mixDuration;
		internal float interruptAlpha;
		internal float totalAlpha;
		internal readonly ExposedList<int> timelineData;
		internal readonly ExposedList<TrackEntry> timelineDipMix;
		internal readonly ExposedList<float> timelinesRotation;
		[CompilerGenerated]
		private AnimationState.TrackEntryDelegate Start;
		[CompilerGenerated]
		private AnimationState.TrackEntryDelegate Interrupt;
		[CompilerGenerated]
		private AnimationState.TrackEntryDelegate End;
		[CompilerGenerated]
		private AnimationState.TrackEntryDelegate Dispose;
		[CompilerGenerated]
		private AnimationState.TrackEntryDelegate Complete;
		[CompilerGenerated]
		private AnimationState.TrackEntryEventDelegate Event;
	
		// Properties
		public int TrackIndex { get; }
		public Animation Animation { get; }
		public bool Loop { get; set; }
		public float Delay { get; set; }
		public float TrackTime { get; set; }
		public float TrackEnd { get; set; }
		public float AnimationStart { get; set; }
		public float AnimationEnd { get; set; }
		public float AnimationLast { get; set; }
		public float AnimationTime { get; }
		public float TimeScale { get; set; }
		public float Alpha { get; set; }
		public float EventThreshold { get; set; }
		public float AttachmentThreshold { get; set; }
		public float DrawOrderThreshold { get; set; }
		public TrackEntry Next { get; }
		public bool IsComplete { get; }
		public float MixTime { get; set; }
		public float MixDuration { get; set; }
		public TrackEntry MixingFrom { get; }
	
		// Events
		public event AnimationState.TrackEntryDelegate Start {
			add;
			remove;
		}
		public event AnimationState.TrackEntryDelegate Interrupt {
			add;
			remove;
		}
		public event AnimationState.TrackEntryDelegate End {
			add;
			remove;
		}
		public event AnimationState.TrackEntryDelegate Dispose {
			add;
			remove;
		}
		public event AnimationState.TrackEntryDelegate Complete {
			add;
			remove;
		}
		public event AnimationState.TrackEntryEventDelegate Event {
			add;
			remove;
		}
	
		// Constructors
		public TrackEntry();
	
		// Methods
		public void Reset();
		internal TrackEntry SetTimelineData(TrackEntry to, ExposedList<TrackEntry> mixingToArray, HashSet<int> propertyIDs);
		private bool HasTimeline(int id);
		internal void OnStart();
		internal void OnInterrupt();
		internal void OnEnd();
		internal void OnDispose();
		internal void OnComplete();
		internal void OnEvent(Event e);
		public void ResetRotationDirections();
		public override string ToString();
	}
}
