/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageShadowAnimator : MonoBehaviour
	{
		// Fields
		private Projector projector;
		private bool isInitialized;
		private float animationOffset;
		private float startAspect;
		private float endAspect;
		private Animator playerAnimator;
	
		// Constructors
		public MyPageShadowAnimator();
	
		// Methods
		public void Init(Animator playerAnimator, float rotationAngle, float startAspect, float endAspect, float animationOffset);
		private void Update();
	}
}
