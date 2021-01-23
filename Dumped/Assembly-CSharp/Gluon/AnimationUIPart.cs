/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class AnimationUIPart : AnimationUIPartBase
	{
		// Fields
		public Ease easeType;
		public float duration;
		public float delay;
		public float delayReverse;
		public EaseFunction customEaseFunction;
		public EaseFunction customEaseFunctionReverse;
		public float overshootOrAmplitudeCustom;
		private CustomEaseFunction _easeFunction;
		public Tweener curTweener;
	
		// Properties
		public CustomEaseFunction easeFunction { get; }
	
		// Constructors
		public AnimationUIPart();
	
		// Methods
		public override void Init();
	}
}
