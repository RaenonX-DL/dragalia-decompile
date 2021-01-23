/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class SimpleAnimationButton : AnimationUIBase
	{
		// Fields
		protected PointerEventHandler pointEventHandler;
		public bool isStop;
		private bool isStarted;
		[CompilerGenerated]
		private bool _isExitAnimationCompleted_k__BackingField;
	
		// Properties
		public bool isExitAnimationCompleted { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public SimpleAnimationButton();
	
		// Methods
		public override void Awake();
		private void Start();
		private void OnEnable();
		private void OnDisable();
		public override void StartEnterAnimation(Action onAnimationDone = null);
		public override void StartExitAnimation(Action onAnimationDone = null);
		public void ForceStartEnterAnimation(Action onAnimationDone = null);
		public void ForceStartExitAnimation(Action onAnimationDone = null);
		public override void ResetUIAnimations();
		public void ModifyEnterDelay(int frame);
		[CompilerGenerated]
		private void _Awake_b__7_0();
	}
}
