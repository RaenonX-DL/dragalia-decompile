/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryCanvas : MonoBehaviour
	{
		// Fields
		public MainCameraCtrl mainCameraCtrl;
		public RenderMode tempInGameUIRenderMode;
		public int tempInGameUISortingOrder;
		[SerializeField]
		public GameObject rootObject;
		public StoryBackgroundCanvas backgroundCanvasScript;
		public StoryCharacterCanvas characterCanvasScript;
		[SerializeField]
		private Canvas uiCanvas;
		[SerializeField]
		private StorySettings storySettings;
		[SerializeField]
		private UnityEngine.UI.Text nameTextBase;
		[SerializeField]
		private GameObject nameTextsParent;
		[SerializeField]
		private UnityEngine.UI.Text messageTextBase;
		[SerializeField]
		private RectTransform messageTextParentsBase;
		[SerializeField]
		private UnityEngine.UI.Text monologueTextBase;
		[SerializeField]
		private CanvasGroup monologueTextParentGroupsBase;
		[SerializeField]
		private CanvasGroup telopGroup;
		[SerializeField]
		private Image telopImage;
		[SerializeField]
		private UnityEngine.UI.Text telopMainText;
		[SerializeField]
		private UnityEngine.UI.Text telopSubText;
		[SerializeField]
		private UnityEngine.UI.Text telopMainRubyText;
		[SerializeField]
		private UnityEngine.UI.Text telopSubRubyText;
		[SerializeField]
		private CanvasGroup topicGroup;
		[SerializeField]
		private Image topicImage;
		[SerializeField]
		private Image choiceImage;
		[SerializeField]
		private CanvasGroup choiceGroup;
		[SerializeField]
		private Button[] choiceButtons;
		[SerializeField]
		private UnityEngine.UI.Text[] choiceButtonTexts;
		[SerializeField]
		private CanvasGroup[] choiceButtonGroups;
		[SerializeField]
		private Button skipButton;
		[SerializeField]
		private Button logButton;
		[SerializeField]
		private Button autoButton;
		[SerializeField]
		private Image autoIconImage;
		[SerializeField]
		private CanvasGroup autoIconGroup;
		[SerializeField]
		private Image messagePageIconImage;
		[SerializeField]
		private CanvasGroup messagePageIconGroup;
		[SerializeField]
		private Image chapterIntroPageIconImage;
		[SerializeField]
		private CanvasGroup chapterIntroPageIconGroup;
		[SerializeField]
		private GameObject nextRootObj;
		[SerializeField]
		private Image messageWindowImage;
		[SerializeField]
		private CanvasGroup messageWindowGroup;
		[SerializeField]
		private Image nameWindowImage;
		[SerializeField]
		private CanvasGroup nameWindowGroup;
		[SerializeField]
		private CanvasGroup bottomButtonGroup;
		[SerializeField]
		private RectTransform monologueParent;
		[SerializeField]
		private RectTransform choiceButtonsParent;
	
		// Nested types
		public enum SortingOrder
		{
			Character = 0,
			UIBackground = 1,
			UIMain = 2,
			InGameUI = 300
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__45_2;
			public static UnityAction __9__45_0;
			public static UnityAction __9__45_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetManagerDataArrays_b__45_0();
			internal void _SetManagerDataArrays_b__45_2();
			internal void _SetManagerDataArrays_b__45_1();
		}
	
		// Constructors
		public StoryCanvas();
	
		// Methods
		public void SetManagerDataArrays();
		private void OnDestroy();
		public void SetBackKeyEvent();
		[CompilerGenerated]
		private void _SetBackKeyEvent_b__47_0();
	}
}
