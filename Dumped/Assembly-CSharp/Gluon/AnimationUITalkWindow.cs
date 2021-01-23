/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationUITalkWindow : AnimationUIBase
	{
		// Fields
		[Header]
		[SerializeField]
		private float exitRotationDuration;
		[Header]
		[SerializeField]
		private float exitOverRunZ;
		[Header]
		[SerializeField]
		private float exitOverRunDuration;
		[Header]
		[SerializeField]
		private bool shouldUseCustomDelay;
		[Header]
		[SerializeField]
		private bool plainScaleEnterAnimation;
		[HideInInspector]
		public bool ignoreDelay;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public AnimationUITalkWindow __4__this;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _StartEnterAnimation_b__0(float x);
			internal void _StartEnterAnimation_b__1(float x);
			internal void _StartEnterAnimation_b__2(float x);
			internal void _StartEnterAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public AnimationUITalkWindow __4__this;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _StartExitAnimation_b__0(float x);
			internal void _StartExitAnimation_b__1(float x);
			internal void _StartExitAnimation_b__2(float x);
			internal void _StartExitAnimation_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public AnimationUITalkWindow __4__this;
			public Action changeTextAction;
			public Action onAnimationDone;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _StartCloseOpenAnimation_b__0(float x);
			internal void _StartCloseOpenAnimation_b__1();
			internal void _StartCloseOpenAnimation_b__2(float x);
			internal void _StartCloseOpenAnimation_b__3(float x);
			internal void _StartCloseOpenAnimation_b__4(float x);
			internal void _StartCloseOpenAnimation_b__5();
		}
	
		// Constructors
		public AnimationUITalkWindow();
	
		// Methods
		public override void Awake();
		public override void StartEnterAnimation(Action onAnimationDone = null);
		public override void StartExitAnimation(Action onAnimationDone = null);
		public void StartCloseOpenAnimation(Action changeTextAction, Action onAnimationDone = null);
		public override void ResetUIAnimations();
		public void ResetEnterAnimationPlayStatus();
		public void ResetExitAnimationPlayStatus();
	}
}
