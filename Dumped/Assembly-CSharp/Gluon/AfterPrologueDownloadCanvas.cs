/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AfterPrologueDownloadCanvas : MonoBehaviour
	{
		// Fields
		public PageViewBase pageView;
		public GameObject pagerCenter;
		public Image[] charaHeaderBgs;
		public Image[] stars;
		public Image[] elementIcons;
		public Image[] weaponIcons;
		public UnityEngine.UI.Text charaName;
		public UnityEngine.UI.Text charaDesc;
		public GameObject checkMark;
		public UnityEngine.UI.Text downloadPercentText;
		public UnityEngine.UI.Text downloadingText;
		public GameObject charaHeader;
		public GameObject charaDetailButton;
		public GameObject charaFooter;
		public AnimationUITalkWindow talkWindow;
		public RectTransform tutorialFooterRectTransform;
		public CanvasGroup tutorialFooterCanvasGroup;
		public Gauge gauge;
		public GameObject gaugeBar;
		public GameObject gaugeBarCompleted;
		public RectTransform dotsRectTransform;
		public Image[] dots;
		public CanvasGroup frontBlackCG;
		private static List<TutorialUnitSelectListElement> charaList;
		private static List<int> charaIds;
		public float moveDuration;
		public static string prefabDir;
		private static string pagePrefabPath;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<TutorialUnitSelectListElement> __9__28_0;
			public static Action<GameObject, int> __9__28_1;
			public static TweenCallback __9__40_1;
			public static TweenCallback __9__43_1;
			public static TweenCallback __9__46_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Start_b__28_0(TutorialUnitSelectListElement a, TutorialUnitSelectListElement b);
			internal void _Start_b__28_1(GameObject page, int index);
			internal void _ExecuteCharaFooterStartAnimation_b__40_1();
			internal void _ExecuteCharaHeaderStartAnimation_b__43_1();
			internal void _ExecuteCharaDetailButtonStartAnimation_b__46_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public AfterPrologueDownloadCharaDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _ExecuteTutorialStartAnimation_b__0(float value);
			internal void _ExecuteTutorialStartAnimation_b__1(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _ExecuteTutorialEndAnimation_b__0(float value);
			internal void _ExecuteTutorialEndAnimation_b__1(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _ExecuteCharaFooterStartAnimation_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _ExecuteCharaFooterEndAnimation_b__0(float value);
			internal void _ExecuteCharaFooterEndAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _ExecuteCharaHeaderStartAnimation_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _ExecuteCharaHeaderEndAnimation_b__0(float value);
			internal void _ExecuteCharaHeaderEndAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _ExecuteCharaDetailButtonStartAnimation_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public AfterPrologueDownloadCanvas __4__this;
			public Vector3 from;
			public Vector3 to;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _ExecuteCharaDetailButtonEndAnimation_b__0(float value);
			internal void _ExecuteCharaDetailButtonEndAnimation_b__1();
		}
	
		// Constructors
		public AfterPrologueDownloadCanvas();
		static AfterPrologueDownloadCanvas();
	
		// Methods
		private void Start();
		public void SetCharaInfo(int charaId);
		public void OnBeforePageChange(bool isToLeft);
		public void OnPageChanged(int pageIndex);
		public void OnDetailButtonPressed();
		private void ExecuteTutorialStartAnimation();
		private void ExecuteTutorialEndAnimation();
		public void OnCheckButtonPressed();
		public static List<int> GetFavoriteCharaIdList();
		public static List<TutorialUnitSelectListElement> GetNowTutorialUnitSelectList();
		public static bool IsFavoriteCharaId(int charaId);
		public void SetDownloadPercentage(float value);
		private void ExecuteCharaFooterStartAnimation();
		private void ExecuteCharaFooterEndAnimation();
		private void HideCharaFooter();
		private void ExecuteCharaHeaderStartAnimation();
		private void ExecuteCharaHeaderEndAnimation();
		private void HideCharaHeader();
		private void ExecuteCharaDetailButtonStartAnimation();
		private void ExecuteCharaDetailButtonEndAnimation();
		private void HideCharaDetailButton();
	}
}
