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
	[RequireComponent]
	public class AnimationUIFlash : AnimationUIBase
	{
		// Fields
		[SerializeField]
		private AlphaAnimType alphaAnimType;
		[SerializeField]
		private bool useAlphaCurve;
		[SerializeField]
		private AnimationCurve alphaCurve;
		private FlashPlayer _flashPlayer;
	
		// Properties
		public FlashPlayer flashPlayer { get; set; }
	
		// Nested types
		public enum AlphaAnimType
		{
			FadeInOut = 0,
			FadeOutIn = 1
		}
	
		// Constructors
		public AnimationUIFlash();
	
		// Methods
		protected override void AddToDefaultEnterAnimation();
		protected override void AddToDefaultExitAnimation();
		private void SetFlashAlpha(float alpha);
		private void GetStartEndAlpha(bool isEnter, out float startAlpha, out float endAlpha);
		[CompilerGenerated]
		private void _AddToDefaultEnterAnimation_b__8_0(float x);
		[CompilerGenerated]
		private void _AddToDefaultEnterAnimation_b__8_1(float x);
		[CompilerGenerated]
		private void _AddToDefaultExitAnimation_b__9_0(float x);
		[CompilerGenerated]
		private void _AddToDefaultExitAnimation_b__9_1(float x);
	}
}
