/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	public class SkeletonGhostRenderer : MonoBehaviour
	{
		// Fields
		public float fadeSpeed;
		private Color32[] colors;
		private Color32 black;
		private MeshFilter meshFilter;
		private MeshRenderer meshRenderer;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Fade_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SkeletonGhostRenderer __4__this;
			private int _t_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Fade_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _FadeAdditive_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SkeletonGhostRenderer __4__this;
			private Color32 _black_5__2;
			private int _t_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FadeAdditive_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SkeletonGhostRenderer();
	
		// Methods
		private void Awake();
		public void Initialize(Mesh mesh, Material[] materials, Color32 color, bool additive, float speed, int sortingLayerID, int sortingOrder);
		[IteratorStateMachine]
		private IEnumerator Fade();
		[IteratorStateMachine]
		private IEnumerator FadeAdditive();
		public void Cleanup();
	}
}
