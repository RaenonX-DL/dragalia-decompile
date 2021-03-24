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
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HeaderCanvas : MonoBehaviour
	{
		// Fields
		public static bool ignoreUpdatePresentBadge;
		public Header header;
		public Image headerImage;
		public CaptionCanvas captionCanvas;
		public GameObject iPhoneXBase;
		public GameObject presentBg;
		public GameObject menuBg;
		public GameObject[] presentBgs;
		public GameObject[] menuBgs;
		public HeaderMenuButton menuButton;
		public Badge presentBadge;
		public Badge menuBadge;
		public bool isSlideOut;
		public bool keepMenuButtonSelectedImage;
		private Canvas canvas;
		private bool isAnimating;
		[SerializeField]
		private float slideDistanceHeader;
		[SerializeField]
		private float slideDistanceCaption;
		private RectTransform headerRectTrans;
		private RectTransform captionRectTrans;
		private RectTransform presentButtonRectTrans;
		private RectTransform menuButtonRectTrans;
		private float defaultYHeader;
		private float defaultYCaption;
		private float defaultYItem;
		private Queue<CaptionAnimationRequest> captionAnimationRequestList;
		private static HeaderCanvas _instance;
	
		// Properties
		public static HeaderCanvas instance { get; }
	
		// Nested types
		public enum Direction
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		private enum CaptionAnimationRequest
		{
			Enter = 0,
			Exit = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public HeaderCanvas obj;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal bool _MoveMeToScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _MoveMeToScene_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HeaderCanvas obj;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MoveMeToScene_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__38_0;
			public static Func<bool> __9__38_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__38_0();
			internal bool _Start_b__38_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HeaderCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ResetCameraCoroutine_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HeaderCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResetCameraCoroutine_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public HeaderCanvas();
		static HeaderCanvas();
	
		// Methods
		public static bool IsInstanceEmpty();
		protected virtual void OnDestroy();
		[IteratorStateMachine]
		public static IEnumerator MoveMeToScene(HeaderCanvas obj);
		public static bool DoMoveMeToScene(HeaderCanvas obj);
		public static MenuPopup GetMenuPopup();
		public static void SetMenuPopup(MenuPopup menuPopup);
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void Reload();
		public void ResetPresentAndMenuBg();
		public void ResetCamera();
		[IteratorStateMachine]
		private IEnumerator ResetCameraCoroutine();
		public void ShowCaption(string title, CaptionCanvas.IconType iconType, bool ignoreSameTitle = false);
		public void HideCaption();
		private void HandleRequest();
		public void SetCaptionAutoAnimationState(bool v);
		public void ShowPresentAndMenuButton();
		public void HidePresentAndMenuButton();
		public void SlideIn(float duration = 0.3f, Direction itemMenuDirection = Direction.Vertical, bool needSlideInCaption = true);
		public void SlideOut(float duration = 0.3f, Direction itemMenuDirection = Direction.Vertical);
		private void MoveTo(RectTransform targetRectTransform, float startY, float endY, float duration);
		private void MoveWithScale(Sequence mainSeq, RectTransform targetRectTransform, float startY, float endY, float duration, float endScale);
		public void SlideInFade(float duration = 0.3f);
		public void SlideOutFade(float duration = 0.3f);
		public void PresentAndMenuButtonSlideIn(float duration = 0.3f, Direction itemMenuDirection = Direction.Horizontal);
		public void PresentAndMenuButtonSlideOut(float duration = 0.3f, Direction itemMenuDirection = Direction.Horizontal);
		private void SetPresentAndMenuButtonInteractable(bool interactable);
		public void SetInteractableButtons(bool interactable);
		public void ResetPressedState();
		public void ResetMenuButtonSelectedImage();
		private void InitCaptionRectTrans(RectTransform rectTrans);
		[CompilerGenerated]
		private void _HandleRequest_b__45_0();
		[CompilerGenerated]
		private void _HandleRequest_b__45_1();
		[CompilerGenerated]
		private void _MoveTo_b__51_0();
		[CompilerGenerated]
		private void _SlideInFade_b__53_0();
		[CompilerGenerated]
		private void _SlideOutFade_b__54_0();
	}
}
