/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BackButton : Button
	{
		// Fields
		private static readonly Vector3 initPosition;
		private static readonly Vector3 initPositionWithoutFooter;
		private const int imageGraphicGroupIndex = 0;
		private const int textGraphicGroupIndex = 1;
		private SimpleAnimationButton simpleAnimationButton;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public SimpleAnimationButton simpleAnimationButton;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _DelayExchangeBackButtonImageToText_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BackButton __4__this;
			public string text;
			public bool isCrossfading;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayExchangeBackButtonImageToText_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BackButton();
		static BackButton();
	
		// Methods
		public static BackButton Create(Canvas canvas, UnityAction prevAction, SceneBase scene, bool isFromEventPage = false);
		protected override void Awake();
		public void SetAutoExitAnimationEnabled(bool enable);
		public void ForceStartEnterAnimation(Action onAnimationDone = null);
		public void ForceStartExitAnimation(Action onAnimationDone = null);
		public void ExchangeBackButtonImageToText(string text, bool isCrossfading);
		[IteratorStateMachine]
		private IEnumerator DelayExchangeBackButtonImageToText(string text, bool isCrossfading);
		public void ExchangeBackButtonTextToImage(bool isCrossfading);
	}
}
