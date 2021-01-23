/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactFacialExpression : MonoBehaviour
	{
		// Fields
		private Material targetMaterial;
		private const int faceCountInRow = 4;
		private const float textureWidth = 0.125f;
		private Sequence runningSeq;
		private Coroutine runningCoroutine;
		private bool useAutoFacialControllerAnimation;
		private FacialAnimationType currentFacialAnimationType;
		private DragonFacialController facialController;
	
		// Nested types
		public enum FacialAnimationType
		{
			None = 0,
			Idle = 1,
			Petting = 2,
			Hate = 3
		}
	
		private enum BlinkTextureIndex
		{
			Open = 0,
			Close = 1,
			Half = 2,
			Damaged = 3
		}
	
		[CompilerGenerated]
		private sealed class _RunIdleFacialExpressionLoopCoroutine_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ContactFacialExpression __4__this;
			private float _closeTime_5__2;
			private float _halfTime_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RunIdleFacialExpressionLoopCoroutine_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AutoChangeBackFromHateState_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitTime;
			public ContactFacialExpression __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AutoChangeBackFromHateState_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ContactFacialExpression();
	
		// Methods
		private void Start();
		private void TerminateRunningSequenceAndCoroutine();
		public void RunIdleFacialExpression(bool isForceStartAutoBlink = false);
		[IteratorStateMachine]
		private IEnumerator RunIdleFacialExpressionLoopCoroutine();
		public void RunPettingFacialExpression();
		public void ResetFacialExpression();
		public void RunHateFacialExpression(float maxTime);
		[IteratorStateMachine]
		private IEnumerator AutoChangeBackFromHateState(float waitTime);
		private void UpdateBlinkMaterial(BlinkTextureIndex textureIndex);
		[CompilerGenerated]
		private void _RunIdleFacialExpression_b__12_0();
		[CompilerGenerated]
		private void _RunIdleFacialExpressionLoopCoroutine_b__13_0();
		[CompilerGenerated]
		private void _RunIdleFacialExpressionLoopCoroutine_b__13_1();
		[CompilerGenerated]
		private bool _RunIdleFacialExpressionLoopCoroutine_b__13_2();
	}
}
