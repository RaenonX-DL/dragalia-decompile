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
	public class StoryTextManager : SingletonMonoBehaviour<Gluon.StoryTextManager>
	{
		// Fields
		public float messageAdjustBaseHeight;
		public int messageLineMax;
		public float messageLineHeightDiff;
		public float monologueAdjustBaseHeight;
		public int monologueLineMax;
		public float monologueLineHeightDiff;
		public float outlineAdjustBaseHeight;
		public int outlineLineMax;
		public float outlineLineHeightDiff;
		public float bookTextAdjustBaseHeight;
		public int bookTextLineMax;
		public float bookTextLineHeightDiff;
		public int nameLineLetterMax;
		public int messageLineLetterMax;
		public int monologueLineLetterMax;
		public float showOneLetterInterval;
		public float showMonologueOneLineInterval;
		public float hideMonologueSeconds;
		public float rubyUpCoefficient;
		public float rubySizeCoefficient;
		public float outlineRubyUpCoefficient;
		public float outlineRubySizeCoefficient;
		public Vector2[] chapterIntroductionTextsParentsBasePos;
		public RectTransform monologueParent;
		public Font baseFont;
		public List<LogData> logDataList;
		public LogData currentLogData;
		public RectTransform[] messageTextsParents;
		public Vector2[] messageTextsParentsBasePos;
		public PageData pageData;
		public static readonly Color monologueBackgroundColor;
		private const float dragonStoryMonologueDownValue = 160f;
	
		// Nested types
		public class PageData
		{
			// Fields
			public string baseNameString;
			public UnityEngine.UI.Text nameTextBase;
			public UnityEngine.UI.Text[] nameTexts;
			public string baseMessageString;
			public string[] messages;
			public UnityEngine.UI.Text messageTextBase;
			public UnityEngine.UI.Text[][] messageTexts;
			public string baseMonologueString;
			public string[] monologues;
			public UnityEngine.UI.Text monologueTextBase;
			public CanvasGroup[] monologueGroups;
			public float[] lineWidths;
			public bool isFirst;
			public bool isTouch;
			public bool isChoice;
			public bool isEnd;
			public float subWaitTime;
			public int textPauseCount;
			public int textRestartCount;
			public List<Tweener> tweenList;
			public List<float> showLetterWaitTime;
			public StoryImage messageWindowData;
			public StoryImage nameWindowData;
			public StoryImage pageIconData;
			public StoryImage chapterIntroPageIconData;
			public bool isNoNeedTouchWait;
			public int totalLetterNum;
			public int showLetterNum;
			public int showMonologueLineNum;
			public int textSize;
			public Color textColor;
			public Tweener textTween;
			public List<Tweener> rubyTweenList;
	
			// Constructors
			public PageData();
	
			// Methods
			public void SetDefault(bool isFirst = true, bool isEnd = true);
			public void SetDefaultNames();
			public void SetDefaultMessages();
			public void SetDefaultMonologues();
			public void AdjustNamesPos();
			public void AdjustMessagesPos();
			public float GetStartSubCommandDelay();
			public void AddSubCommandCallback(TweenCallback callback, float adjustDelay = 0f);
			public void SetWaitPrint(bool isWait);
		}
	
		public class LogData
		{
			// Fields
			public StoryScriptFunctionManager.WindowType windowType;
			public string nameString;
			public string textString;
			public string voiceId;
	
			// Constructors
			public LogData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public StoryTextManager __4__this;
			public int showedLetter;
			public StoryScriptFunctionManager.State nextState;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _ShowMessageText_b__0(float sec);
			internal void _ShowMessageText_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public int rubyLength;
			public int messageLength;
			public UnityEngine.UI.Text rubyText;
			public string tempRubyString;
			public StoryTextManager __4__this;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _AddMessageText_b__0();
			internal void _AddMessageText_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_1
		{
			// Fields
			public Tweener tween;
			public __c__DisplayClass40_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass40_1();
	
			// Methods
			internal void _AddMessageText_b__2(float length);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__43_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _HideMonologueText_b__43_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public StoryImage pageIcon;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _SetVisiblePageIcon_b__0(float fade);
		}
	
		// Constructors
		public StoryTextManager();
		static StoryTextManager();
	
		// Methods
		public void SetDefault();
		public static void ClearTweenList(List<Tweener> tweenList, bool complete = false);
		public void SetNameText(bool visible, string nameString);
		public void SetCompleteSubCommandData();
		public void ShowMessageText();
		public void UpdateShowMessage(int showLength, StoryScriptFunctionManager.State nextState);
		public void AddMessageText(string messageString, string rubyString = null);
		public void ShowMonologueText();
		public void CompleteShowMonologue();
		public void HideMonologueText();
		public void AddMonologueText(string monologueString, string rubyString = null);
		public static ArrayList CreateSpritStringArray(string baseStr, int lineLetterMax);
		public void SetVisiblePageIcon(bool visible, StoryImage pageIcon);
		public static string ReplaceDoubleQuotation(string baseString);
		public static string ReplaceCircleEmpty(string baseString);
		[CompilerGenerated]
		private void _ShowMonologueText_b__41_0(float fade);
		[CompilerGenerated]
		private void _ShowMonologueText_b__41_1();
		[CompilerGenerated]
		private void _HideMonologueText_b__43_0(float fade);
	}
}
