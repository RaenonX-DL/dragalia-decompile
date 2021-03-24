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
	public class AnimationState
	{
		// Fields
		private static readonly Animation EmptyAnimation;
		internal const int Subsequent = 0;
		internal const int First = 1;
		internal const int Dip = 2;
		internal const int DipMix = 3;
		private AnimationStateData data;
		private Pool<TrackEntry> trackEntryPool;
		private readonly ExposedList<TrackEntry> tracks;
		private readonly ExposedList<Event> events;
		private readonly EventQueue queue;
		private readonly HashSet<int> propertyIDs;
		private readonly ExposedList<TrackEntry> mixingTo;
		private bool animationsChanged;
		private float timeScale;
		[CompilerGenerated]
		private TrackEntryDelegate Start;
		[CompilerGenerated]
		private TrackEntryDelegate Interrupt;
		[CompilerGenerated]
		private TrackEntryDelegate End;
		[CompilerGenerated]
		private TrackEntryDelegate Dispose;
		[CompilerGenerated]
		private TrackEntryDelegate Complete;
		[CompilerGenerated]
		private TrackEntryEventDelegate Event;
	
		// Properties
		public AnimationStateData Data { get; }
		public ExposedList<TrackEntry> Tracks { get; }
		public float TimeScale { get; set; }
	
		// Events
		public event TrackEntryDelegate Start {
			add;
			remove;
		}
		public event TrackEntryDelegate Interrupt {
			add;
			remove;
		}
		public event TrackEntryDelegate End {
			add;
			remove;
		}
		public event TrackEntryDelegate Dispose {
			add;
			remove;
		}
		public event TrackEntryDelegate Complete {
			add;
			remove;
		}
		public event TrackEntryEventDelegate Event {
			add;
			remove;
		}
	
		// Nested types
		public delegate void TrackEntryDelegate(TrackEntry trackEntry);
	
		public delegate void TrackEntryEventDelegate(TrackEntry trackEntry, Event e);
	
		// Constructors
		public AnimationState(AnimationStateData data);
		static AnimationState();
	
		// Methods
		public void Update(float delta);
		private bool UpdateMixingFrom(TrackEntry to, float delta);
		public bool Apply(Skeleton skeleton);
		private float ApplyMixingFrom(TrackEntry to, Skeleton skeleton, MixPose currentPose);
		private static void ApplyRotateTimeline(RotateTimeline rotateTimeline, Skeleton skeleton, float time, float alpha, MixPose pose, float[] timelinesRotation, int i, bool firstFrame);
		private void QueueEvents(TrackEntry entry, float animationTime);
		public void ClearTracks();
		public void ClearTrack(int trackIndex);
		private void SetCurrent(int index, TrackEntry current, bool interrupt);
		public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop);
		public TrackEntry SetAnimation(int trackIndex, Animation animation, bool loop);
		public TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay);
		public TrackEntry AddAnimation(int trackIndex, Animation animation, bool loop, float delay);
		public TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration);
		public TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay);
		public void SetEmptyAnimations(float mixDuration);
		private TrackEntry ExpandToIndex(int index);
		private TrackEntry NewTrackEntry(int trackIndex, Animation animation, bool loop, TrackEntry last);
		private void DisposeNext(TrackEntry entry);
		private void AnimationsChanged();
		public TrackEntry GetCurrent(int trackIndex);
		public override string ToString();
		internal void OnStart(TrackEntry entry);
		internal void OnInterrupt(TrackEntry entry);
		internal void OnEnd(TrackEntry entry);
		internal void OnDispose(TrackEntry entry);
		internal void OnComplete(TrackEntry entry);
		internal void OnEvent(TrackEntry entry, Event e);
		[CompilerGenerated]
		private void _.ctor_b__41_0();
	}
}
