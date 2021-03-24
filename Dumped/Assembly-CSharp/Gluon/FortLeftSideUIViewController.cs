/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortLeftSideUIViewController : MonoBehaviour
	{
		// Fields
		private Vector3 defaultPos;
		private bool isAnimating;
		private bool isSlidingOut;
		[SerializeField]
		private float slideDistanceAdd;
		private CanvasGroup canvasGroup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public FortLeftSideUIViewController __4__this;
			public float duration;
			public RectTransform rectTransform;
			public TweenCallback __9__1;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _SlideIn_b__0();
			internal void _SlideIn_b__1();
		}
	
		// Constructors
		public FortLeftSideUIViewController();
	
		// Methods
		private void Start();
		public void SlideIn(float duration = 0.3f);
		public void SlideOut(float duration = 0.3f, bool isSaveCurrentPos = false);
		[CompilerGenerated]
		private void _SlideOut_b__7_0();
	}
}
