/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialDualWindow : TutorialSimpleWindow
	{
		// Fields
		public RectTransform[] pageRectTransform;
		public UnityEngine.UI.Text[] windowTitle;
		public Image[] mainImage;
		public RubySupportedText descText;
		public RubySupportedText fadeText;
		public Button prevButton;
		public Button nextButton;
		public Button skipButton;
		public UnityEngine.UI.Text prevButtonText;
		public UnityEngine.UI.Text nextButtonText;
		public UnityEngine.UI.Text skipButtonText;
		public GameObject pagerCenter;
		public Sprite closeButtonSprite;
		private Action onCompleted;
		private Action skipCallback;
		private int currPageNum;
		private CommonPager[] pagers;
		private const float pagerWidth = 32f;
		private string[] imagefilenames;
		private string[] titleTexts;
		private string[] descTexts;
		private int totalPage;
		private bool isNowAnimation;
		private UIAnimationBase[] uiAnimations;
		private string skipConfirmText;
		private CommonPopup skipPopup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public TutorialDualWindow window;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _CreateTutorialDualWindow_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public TutorialDualWindow __4__this;
			public int outIndex;
			public float outMovePosX;
			public int inIndex;
			public UnityAction __9__4;
			public TweenCallback __9__3;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _PlayPageAnimation_b__0();
			internal void _PlayPageAnimation_b__1();
			internal void _PlayPageAnimation_b__2();
			internal void _PlayPageAnimation_b__3();
			internal void _PlayPageAnimation_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public int finishedAnimationUIs;
			public TutorialDualWindow __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _CloseDualWindow_b__0();
		}
	
		// Constructors
		public TutorialDualWindow();
	
		// Methods
		public static TutorialDualWindow CreateTutorialDualWindow(Canvas canvas, string[] imagefilenames, string[] titleTexts, string[] descTexts, int totalPageNum, Action onCompleted, string skipConfirmText = "", Action skipCallback = null);
		public void SetWindowTitle(string title, int index);
		public void SetMainImage(string filename, int imageIndex);
		public void OnPrevButtonPressed();
		public void OnNextButtonPressed();
		private void PlayPageAnimation(bool isNextPage);
		public void OnSkipButtonPressed();
		private void CloseDualWindow();
		public void StartEnterAnimation();
		[CompilerGenerated]
		private void _OnSkipButtonPressed_b__32_0();
	}
}
