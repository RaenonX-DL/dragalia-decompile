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
	public class AnimationUIExpand : AnimationUIPart
	{
		// Fields
		[SerializeField]
		private Ease easeTypeReverse;
		[SerializeField]
		private float startWidth;
		[SerializeField]
		private float endWidth;
	
		// Constructors
		public AnimationUIExpand();
	
		// Methods
		public override void Init();
		public override void Execute(bool isReverse = false);
		[CompilerGenerated]
		private void _Execute_b__4_0(float value);
		[CompilerGenerated]
		private void _Execute_b__4_1(float value);
	}
}
