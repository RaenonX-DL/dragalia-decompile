/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TitleCanvas : MonoBehaviour, ICustomMessage
	{
		// Fields
		public TitleScene scene;
		public GameObject copyright;
		public GameObject criMark;
		public GameObject suggestionBoxButton;
		public GameObject menuButton;
		public Badge menuButtonBadge;
		public GameObject suggestionBoxButtonPressedMark;
		public GameObject menuButtonPressedMark;
		public GameObject company1;
		public GameObject company1X;
		public GameObject company2;
		public GameObject company2X;
		public GameObject topBgForLongDevice;
		public GameObject bottomBgForLongDevice;
		public GameObject touchGuard;
		public UnityEngine.UI.Text suggestionBoxText;
		public UnityEngine.UI.Text menuText;
		public UnityEngine.UI.Text titleVersionText;
		public UnityEngine.UI.Text titleViewerIdText;
		public GameObject showDebugButton;
		public CanvasGroup frontBlackCG;
		public bool isStartAnimationDone;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public RectTransform criMarkRectTransform;
			public Vector2 criMarkPos;
			public CanvasGroup criMarkCanvasGroup;
			public RectTransform suggestionBoxButtonRectTransform;
			public Vector2 suggestionBoxButtonPos;
			public CanvasGroup suggestionBoxButtonCanvasGroup;
			public RectTransform menuButtonRectTransform;
			public Vector2 menuButtonPos;
			public CanvasGroup menuButtonCanvasGroup;
			public RectTransform company1RectTransform;
			public Vector2 company1Pos;
			public CanvasGroup company1CanvasGroup;
			public RectTransform company2RectTransform;
			public Vector2 company2Pos;
			public CanvasGroup company2CanvasGroup;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _StartEnterAnimationCoroutine_b__0(float value);
			internal void _StartEnterAnimationCoroutine_b__1(float value);
			internal void _StartEnterAnimationCoroutine_b__2(float value);
			internal void _StartEnterAnimationCoroutine_b__3(float value);
			internal void _StartEnterAnimationCoroutine_b__4(float value);
		}
	
		[CompilerGenerated]
		private sealed class _StartEnterAnimationCoroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartEnterAnimationCoroutine_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TitleCanvas();
	
		// Methods
		private void Start();
		private void OnDisable();
		public void StartEnterAnimation();
		[IteratorStateMachine]
		private IEnumerator StartEnterAnimationCoroutine();
		public void EnableTouchGurad(bool enable);
		public void DoFade(float duration);
		public void OnTouchGuardPressed();
		public void OnTitleButtonPressed();
		public void OnMenuButtonPressed();
		public void OnSuggestionBoxButtonPressed();
		public void UnloadFont();
		public void UpdateInquireBadge(bool isHavingUnreadComments);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		private bool IsTooLongDevice();
	}
}
