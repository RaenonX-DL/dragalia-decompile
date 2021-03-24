/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class SceneRadialGodray : MonoBehaviour
	{
		// Fields
		[Range]
		[SerializeField]
		[Tooltip]
		private float FadeStartRotationRateX;
		[Range]
		[SerializeField]
		[Tooltip]
		private float FadeEndRotationRateX;
		[SerializeField]
		[Tooltip]
		private float EffectMoveRateX;
		[SerializeField]
		[Tooltip]
		private float EffectMoveRateZ;
		[SerializeField]
		[Tooltip]
		private float EffectScreenOffsetX;
		[SerializeField]
		[Tooltip]
		private float EffectScreenOffsetY;
		[Range]
		[SerializeField]
		[Tooltip]
		private float EffectMoveXCorrectionByAspect;
		private const float BaseAspectRatio = 1.775f;
		private SPFXInstance effectInstanceObject;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayEffectCoroutine_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneRadialGodray __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayEffectCoroutine_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SceneRadialGodray();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator PlayEffectCoroutine();
		private void Update();
	}
}
