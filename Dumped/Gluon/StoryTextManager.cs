using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryTextManager : SingletonMonoBehaviour<StoryTextManager>
	{
		public class PageData
		{
			public string baseNameString;

			public Text nameTextBase;

			public Text[] nameTexts;

			public string baseMessageString;

			public string[] messages;

			public Text messageTextBase;

			public Text[][] messageTexts;

			public string baseMonologueString;

			public string[] monologues;

			public Text monologueTextBase;

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

			public void SetDefault(bool isFirst = true, bool isEnd = true)
			{
			}

			public void SetDefaultNames()
			{
			}

			public void SetDefaultMessages()
			{
			}

			public void SetDefaultMonologues()
			{
			}

			public void AdjustNamesPos()
			{
			}

			public void AdjustMessagesPos()
			{
			}

			public float GetStartSubCommandDelay()
			{
				return default(float);
			}

			public void AddSubCommandCallback(TweenCallback callback, float adjustDelay = 0f)
			{
			}

			public void SetWaitPrint(bool isWait)
			{
			}
		}

		public class LogData
		{
			public StoryScriptFunctionManager.WindowType windowType;

			public string nameString;

			public string textString;

			public string voiceId;
		}

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

		public void SetDefault()
		{
		}

		public static void ClearTweenList(List<Tweener> tweenList, bool complete = false)
		{
		}

		public void SetNameText(bool visible, string nameString)
		{
		}

		public void SetCompleteSubCommandData()
		{
		}

		public void ShowMessageText()
		{
		}

		public void UpdateShowMessage(int showLength, StoryScriptFunctionManager.State nextState)
		{
		}

		public void AddMessageText(string messageString, [Optional] string rubyString)
		{
		}

		public void ShowMonologueText()
		{
		}

		public void CompleteShowMonologue()
		{
		}

		public void HideMonologueText()
		{
		}

		public void AddMonologueText(string monologueString, [Optional] string rubyString)
		{
		}

		public static ArrayList CreateSpritStringArray(string baseStr, int lineLetterMax)
		{
			return null;
		}

		public void SetVisiblePageIcon(bool visible, StoryImage pageIcon)
		{
		}

		public static string ReplaceDoubleQuotation(string baseString)
		{
			return null;
		}

		public static string ReplaceCircleEmpty(string baseString)
		{
			return null;
		}
	}
}
