/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleMotifObject : GrowthManaCircleDraggable, IPointerClickHandler
	{
		// Fields
		public MotifType type;
		public EffectObject effect;
		public int circleIndex;
		public bool isEffectPlaying;
		public bool isReleased;
		private const float doubleTouchThreshold = 0.25f;
	
		// Nested types
		public enum MotifType
		{
			ReleaseLimit = 0,
			Symbol = 1,
			Max = 2
		}
	
		[CompilerGenerated]
		private sealed class _PlayReleaseLimitWaitingEffectCoroutine_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public GrowthManaCircleMotifObject __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayReleaseLimitWaitingEffectCoroutine_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StopEffectCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public GrowthManaCircleMotifObject __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StopEffectCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleMotifObject();
	
		// Methods
		public void Start();
		public void SetTouchEnabled(bool arg);
		public void PlayReleaseLimitWaitingEffect(float delay = 0f);
		[IteratorStateMachine]
		private IEnumerator PlayReleaseLimitWaitingEffectCoroutine(float delay);
		public void StopEffect(float delay);
		[IteratorStateMachine]
		private IEnumerator StopEffectCoroutine(float delay);
		public void OnPointerClick(PointerEventData eventData);
		protected override void NotifyDraggingToScene(bool arg);
		public void PlayPlusValueChangeAnimation(int state);
	}
}
