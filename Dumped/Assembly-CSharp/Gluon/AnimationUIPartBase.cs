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
	public abstract class AnimationUIPartBase : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private bool _isAnimating_k__BackingField;
		[CompilerGenerated]
		private Action<bool> _onAnimationFinished_k__BackingField;
		protected bool _isReverseAnimation;
		private RectTransform _rectTransform;
		private bool isInited;
	
		// Properties
		public bool isAnimating { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<bool> onAnimationFinished { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isReverseAnimation { get; }
		public RectTransform rectTransform { get; }
	
		// Constructors
		protected AnimationUIPartBase();
	
		// Methods
		public virtual void Init();
		public virtual void Execute(bool isReverse = false);
		protected virtual void OnAnimationFinished();
		public virtual void Kill();
	}
}
