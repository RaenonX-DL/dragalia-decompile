/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TapEffectCanvas : SingletonInBaseMonoBehaviour<Gluon.TapEffectCanvas>
	{
		// Fields
		public LongTapParameter longTapParameter;
		public TapEffect tapEffect;
		public TapEffect bigTapEffect;
		public LongTapTrail longTapTrail;
		public LongTapParticle longTapParticle;
		public RectTransform longTapTop;
		public RectTransform canvasRectTransform;
		public bool isBigEffect;
		public Sprite[] midSprite;
		public Sprite[] bigSprite;
		public Material[] midMaterial;
		public Material[] bigMaterial;
		private int longTapCount;
		private int longTapStopCount;
		private float lastTouchPositionX;
		private float lastTouchPositionY;
		private const int longTapCountThreashold = 5;
		private bool isLoaded;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TapEffectCanvas __4__this;
			private int _size_5__2;
			private int _i_5__3;
			private Material _mat_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayTapEffectCoroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TapEffectCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayTapEffectCoroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TapEffectCanvas();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private void LateUpdate();
		private void GetTouchPositionInCanvas(out float x, out float y);
		[IteratorStateMachine]
		private IEnumerator PlayTapEffectCoroutine();
		public void PlayBigTapEffect();
		[CompilerGenerated]
		private bool _PlayTapEffectCoroutine_b__21_0();
	}
}
