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
	[RequireComponent]
	public class AnimationListOneCol : MonoBehaviour
	{
		// Fields
		public List<SimpleAnimationCell> animationCells;
		[SerializeField]
		private bool _autoExcuteAnimationInStart;
		[SerializeField]
		private float _startCellAlpha;
		private bool keepingTouchGuard;
	
		// Properties
		public bool autoExcuteAnimationInStart { get; set; }
		public float startCellAlpha { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<SimpleAnimationCell> __9__14_0;
			public static Comparison<SimpleAnimationCell> __9__16_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _ExecuteEnterAnimation_b__14_0(SimpleAnimationCell a, SimpleAnimationCell b);
			internal int _ExecuteExitAnimation_b__16_0(SimpleAnimationCell a, SimpleAnimationCell b);
		}
	
		[CompilerGenerated]
		private sealed class _ExecuteEnterAnimation_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AnimationListOneCol __4__this;
			public float delayTime;
			public bool isTableView;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecuteEnterAnimation_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ExecuteExitAnimation_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isEnableTouchGuardOnAnimation;
			public AnimationListOneCol __4__this;
			public float delayTime;
			public bool isTableView;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecuteExitAnimation_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AnimationListOneCol();
	
		// Methods
		private void OnDisable();
		public void ClearAnimationCells();
		public void AddAnimationCell(SimpleAnimationCell animationCell, int delayIndex);
		public void StartEnterAnimation(bool isTableView = false, float delayTime = 0f);
		[IteratorStateMachine]
		private IEnumerator ExecuteEnterAnimation(bool isTableView, float delayTime);
		public void StartExitAnimation(bool isTableView = false, float delayTime = 0f, bool isEnableTouchGuardOnAnimation = false);
		[IteratorStateMachine]
		private IEnumerator ExecuteExitAnimation(bool isTableView, float delayTime, bool isEnableTouchGuardOnAnimation = false);
		public bool IsOnAnimation();
		[CompilerGenerated]
		private bool _ExecuteExitAnimation_b__16_1();
	}
}
