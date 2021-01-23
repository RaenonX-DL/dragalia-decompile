/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class WaitForSpineEvent : IEnumerator
	{
		// Fields
		private EventData m_TargetEvent;
		private string m_EventName;
		private AnimationState m_AnimationState;
		private bool m_WasFired;
		private bool m_unsubscribeAfterFiring;
	
		// Properties
		public bool WillUnsubscribeAfterFiring { get; set; }
		object IEnumerator.Current { get; }
	
		// Constructors
		public WaitForSpineEvent(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true);
		public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, EventData eventDataReference, bool unsubscribeAfterFiring = true);
		public WaitForSpineEvent(AnimationState state, string eventName, bool unsubscribeAfterFiring = true);
		public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring = true);
	
		// Methods
		private void Subscribe(AnimationState state, EventData eventDataReference, bool unsubscribe);
		private void SubscribeByName(AnimationState state, string eventName, bool unsubscribe);
		private void HandleAnimationStateEventByName(TrackEntry trackEntry, Event e);
		private void HandleAnimationStateEvent(TrackEntry trackEntry, Event e);
		public WaitForSpineEvent NowWaitFor(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true);
		public WaitForSpineEvent NowWaitFor(AnimationState state, string eventName, bool unsubscribeAfterFiring = true);
		private void Clear(AnimationState state);
		bool IEnumerator.MoveNext();
		void IEnumerator.Reset();
	}
}
