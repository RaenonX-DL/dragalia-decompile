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
	public class AnimationUIMove : AnimationUIPart
	{
		// Fields
		public Vector2 relativeDistance;
		public Vector2 startPos;
		public Vector2 endPos;
		public bool useRelativeDistance;
		[SerializeField]
		private Ease easeTypeReverse;
		private bool isResetMovePos;
	
		// Constructors
		public AnimationUIMove();
	
		// Methods
		public override void Init();
		public void OnEnable();
		public override void Execute(bool isReverse = false);
	}
}
