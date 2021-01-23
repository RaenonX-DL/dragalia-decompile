/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationUIMoveTwoWay : AnimationUIPart
	{
		// Fields
		[Header]
		[SerializeField]
		private Vector2 enteringRelativeDistance;
		[SerializeField]
		private Vector2 enteringStartPos;
		[SerializeField]
		private Vector2 enteringEndPos;
		[SerializeField]
		private Ease enteringEaseType;
		[Header]
		[SerializeField]
		private Vector2 exitingRelativeDistance;
		[SerializeField]
		private Vector2 exitingStartPos;
		[SerializeField]
		private Vector2 exitingEndPos;
		[SerializeField]
		private Ease exitingEaseType;
		[SerializeField]
		private bool useRelativeDistance;
		[SerializeField]
		private bool useAlphaFade;
		private CanvasGroup canvasGroup;
		private Tweener curFadeTweener;
	
		// Constructors
		public AnimationUIMoveTwoWay();
	
		// Methods
		public override void Init();
		public override void Execute(bool isExit = false);
	}
}
