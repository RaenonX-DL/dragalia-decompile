/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleManaCircleObject : MonoBehaviour
	{
		// Fields
		public int index;
		public GrowthManaCircleScene scene;
		public GameObject[] pointNodes;
		public GameObject[] pointObjects;
		public GrowthManaCircleManaPieceObject[] points;
		private GrowthManaCircleEffectSettings efs;
		private const int numOfPoints = 10;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__7_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__7_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaCircleObject __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeReleasePointCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaCircleObject __4__this;
			public EffectObject effectObject;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeReleasePointCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AutoReleaseEffectCoroutine_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public GrowthManaCircleManaPieceObject touchPoint;
			public GrowthManaCircleManaCircleObject __4__this;
			public bool isSoundOff;
			private EffectObject _effectObject_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AutoReleaseEffectCoroutine_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReleaseLimitOnPointEffectCoroutine_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaCircleObject __4__this;
			private EffectObject[] _pointEffects_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReleaseLimitOnPointEffectCoroutine_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReleaseLimitFlyingEffectCoroutine_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaCircleObject __4__this;
			public Vector3 lockObjectPosition;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReleaseLimitFlyingEffectCoroutine_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AllReleaseOnPointEffectCoroutine_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaCircleObject __4__this;
			private EffectObject[] _pointEffects_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AllReleaseOnPointEffectCoroutine_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AllReleaseFlyingEffectCoroutine_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaCircleObject __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AllReleaseFlyingEffectCoroutine_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleManaCircleObject();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public List<int> GetUnReleasedPointIndexList();
		public void SetTouchablePoints(int centerIndex);
		public Vector3 GetTouchPointWorldPosition(int touchPointIndex);
		public void PlayReleasePointEffect(GrowthManaCircleManaPieceObject touchPoint);
		[IteratorStateMachine]
		private IEnumerator ChangeReleasePointCoroutine(EffectObject effectObject);
		public void PlayReleaseAutoEffect(List<GrowthManaCircleManaPieceObject> pointList, bool isSoundOff = false);
		[IteratorStateMachine]
		private IEnumerator AutoReleaseEffectCoroutine(GrowthManaCircleManaPieceObject touchPoint, float delay, bool isSoundOff);
		public void PlayReleaseLimitReadyEffect(Vector3 lockObjectPosition);
		[IteratorStateMachine]
		private IEnumerator ReleaseLimitOnPointEffectCoroutine();
		[IteratorStateMachine]
		private IEnumerator ReleaseLimitFlyingEffectCoroutine(Vector3 lockObjectPosition);
		public void PlayAllReleaseEffect(Vector3 lockObjectPosition);
		[IteratorStateMachine]
		private IEnumerator AllReleaseOnPointEffectCoroutine();
		[IteratorStateMachine]
		private IEnumerator AllReleaseFlyingEffectCoroutine(Vector3 lockObjectPosition);
	}
}
