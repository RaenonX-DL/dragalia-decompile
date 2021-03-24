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
	public class SmoothMove
	{
		// Fields
		[CompilerGenerated]
		private TweenType _tweenType_k__BackingField;
		private Vector3 startPosition;
		private Vector3 endPosition;
		private Transform targetTransform;
		private float duration;
		private float stepTime;
		[CompilerGenerated]
		private bool _isFinished_k__BackingField;
	
		// Properties
		public TweenType tweenType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFinished { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public SmoothMove(Transform transform, Vector3 startPos, Vector3 endPos, float duration);
	
		// Methods
		public void Update();
		protected float GetTweenTime(float delta);
	}
}
