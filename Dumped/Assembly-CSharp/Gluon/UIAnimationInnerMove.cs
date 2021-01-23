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
	public class UIAnimationInnerMove : UIAnimationBase
	{
		// Fields
		protected float moveDistance;
		protected float overrunBounceDistance;
		protected float postOverrunExtension;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public UIAnimationInnerMove __4__this;
			public Vector3 initialPosition;
			public Vector3 overrunPosition;
			public Vector3 endPosition;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _JoinEnterAnimation_b__0(float x);
			internal void _JoinEnterAnimation_b__1(float x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public UIAnimationInnerMove __4__this;
			public Vector3 initialPosition;
			public Vector3 overrunPosition;
			public Vector3 endPosition;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _JoinExitAnimation_b__0(float x);
			internal void _JoinExitAnimation_b__1(float x);
		}
	
		// Constructors
		public UIAnimationInnerMove();
	
		// Methods
		protected override void JoinEnterCanvasGroupAnimation();
		protected override void JoinExitCanvasGroupAnimation();
		public override void ApplySetting(UIAnimationSetting anotherSetting);
		protected override void JoinEnterAnimation();
		protected override void JoinExitAnimation();
		protected override float AppendExtraToEnterAnimation();
		protected override float AppendExtraToExitAnimation();
	}
}
