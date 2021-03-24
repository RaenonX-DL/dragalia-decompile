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
	public class TapEffectTitleCanvas : SingletonMonoBehaviour<Gluon.TapEffectTitleCanvas>
	{
		// Fields
		public bool showEffect;
		public TapEffectTitle tapEffect;
		public TapEffectTitle bigTapEffect;
		public RectTransform canvasRectTransform;
		public bool isBigEffect;
		public Sprite[] midSprite;
		public Sprite[] bigSprite;
		public Material[] midMaterial;
		public Material[] bigMaterial;
		private bool isInitalized;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _InitalizeCoroutine_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TapEffectTitleCanvas __4__this;
			private int _size_5__2;
			private int _i_5__3;
			private Material _mat_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitalizeCoroutine_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayTapEffectCoroutine_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TapEffectTitleCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayTapEffectCoroutine_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TapEffectTitleCanvas();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator InitalizeCoroutine();
		private void LateUpdate();
		public void DoNothing();
		[IteratorStateMachine]
		private IEnumerator PlayTapEffectCoroutine();
		public void PlayBigTapEffect();
	}
}
