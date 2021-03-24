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
	[ExecuteAlways]
	public class KeepStableToTransform : MonoBehaviour
	{
		// Fields
		public Transform keepStableTo;
		public string findKeepInScene;
		public string specifySceneName;
		public bool ignoreZOffset;
		public bool onlyPosition;
		public bool stableOnFirstEnableState;
		public Vector3 freezeScale;
		public int traceDelayFrame;
		private Vector3 offset;
		private bool resetOnDisable;
		private bool initialOffsetSet;
		private List<TraceTargetInfo> delayedTracePosition;
	
		// Nested types
		private class TraceTargetInfo
		{
			// Fields
			public Vector3 position;
			public Quaternion rotation;
			public Vector3 localScale;
	
			// Constructors
			public TraceTargetInfo(Vector3 position, Quaternion rotation, Vector3 localScale);
			public TraceTargetInfo(Transform t);
		}
	
		[CompilerGenerated]
		private sealed class _OnEnableCoroutine_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public KeepStableToTransform __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnEnableCoroutine_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public KeepStableToTransform();
	
		// Methods
		private void OnEnable();
		[IteratorStateMachine]
		private IEnumerator OnEnableCoroutine();
		private void OnDisable();
		public void FollowUp();
		private void LateUpdate();
		[CompilerGenerated]
		private bool _OnEnableCoroutine_b__14_0();
	}
}
