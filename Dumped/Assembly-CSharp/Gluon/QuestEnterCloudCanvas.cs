/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEnterCloudCanvas : SingletonInBaseMonoBehaviour<Gluon.QuestEnterCloudCanvas>
	{
		// Fields
		public static bool skipCreateOnStart;
		public CanvasGroup canvasGroup;
		public CanvasGroup whiteCanvasGroup;
		[CompilerGenerated]
		private bool _isOnAnimation_k__BackingField;
		private FlashPlayer flashPlayer;
		private bool isLoaded;
		private Tweener tweener;
	
		// Properties
		public bool isOnAnimation { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _StartAnimationCoroutine_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEnterCloudCanvas __4__this;
			public Action nextAction;
			public Action hideAfterAction;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAnimationCoroutine_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestEnterCloudCanvas();
	
		// Methods
		public void Init();
		private void Start();
		protected override void OnDestroy();
		public void StartAnimation(Action nextAction, Action hideAfterAction = null);
		[IteratorStateMachine]
		private IEnumerator StartAnimationCoroutine(Action nextAction, Action hideAfterAction = null);
		public void EndAnimation(Action outEndAnimationAction = null);
		[CompilerGenerated]
		private void _Init_b__10_0(int index);
		[CompilerGenerated]
		private bool _StartAnimationCoroutine_b__14_0();
		[CompilerGenerated]
		private void _EndAnimation_b__15_0();
	}
}
