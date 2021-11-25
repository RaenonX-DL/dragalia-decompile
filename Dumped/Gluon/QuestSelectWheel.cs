using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectWheel : MonoBehaviour
	{
		private class PosElement : IComparable<PosElement>
		{
			public Vector3 pos
			{
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int index
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public QuestSelectWheelElement.WheelChapterSize chapterSize
			{
				[CompilerGenerated]
				get
				{
					return default(QuestSelectWheelElement.WheelChapterSize);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public PosElement(Vector3 a_pos, int a_index)
			{
			}

			public int CompareTo(PosElement a_posElement)
			{
				return default(int);
			}
		}

		[Serializable]
		public class NewChapterActionTime
		{
			public float dropCellDelayTime;

			public float titleDelayTime;

			public float bgDelayTime;

			public float otherCellDelayTime;

			public float endDelayTime;
		}

		[SerializeField]
		private Canvas selfCanvas;

		[SerializeField]
		private GameObject orgWheelElement;

		[SerializeField]
		public Button chapterWheelOverAllButton;

		[SerializeField]
		public Button uiChapterLeftButton;

		[SerializeField]
		public Button uiChapterRightButton;

		[SerializeField]
		public Text uiChapterNumberText;

		[SerializeField]
		public Text uiChapterTitleText;

		[SerializeField]
		private GameObject wheel;

		[SerializeField]
		private Image lightImage;

		[SerializeField]
		private Image uiChapterTitlelineImage;

		[SerializeField]
		private Image uiChapterTitleBgImage;

		[SerializeField]
		public GameObject chapterTitleRoot;

		[SerializeField]
		private Image uiBgLayer;

		[SerializeField]
		private CanvasGroup uiArrowCanvasGroup;

		private List<QSChapterElement> chapterList;

		private RectTransform canvasRect;

		private bool touchInCanvas;

		private bool touchFlick;

		private bool touchDrag;

		private bool touchSwipe;

		private QuestSelectWheelElement[] chapterArray;

		private QuestSelectWheelElement[] chapterArrayOrg;

		private int chapterNum;

		private List<QuestMainGroupElement> questGroupList;

		private int maxChapter;

		[SerializeField]
		private float elementsScele;

		[SerializeField]
		private float chapterRot1;

		private const float wheelScale = 0.9f;

		private float rot;

		[SerializeField]
		[Header("å\u009b\u009eè»¢å\u0088\u009dé\u0080\u009fåº¦å®\u009aæ\u0095°")]
		private float rotSpeedFirstConst;

		[SerializeField]
		[Header("æ\u009c\u0080å°\u008fé\u0080\u009fåº¦")]
		private float miniFirstSpeed;

		[SerializeField]
		[Header("ã\u0082¹ã\u0083\u00afã\u0082¤ã\u0083\u0097é\u0080\u009fåº¦")]
		private float swipeSpeed;

		[SerializeField]
		[Header("å\u009fºæ\u009c¬æ\u00b8\u009bé\u0080\u009få®\u009aæ\u0095°")]
		private float breakSpeedOneConst;

		[SerializeField]
		[Header("æ\u009c\u0080å¤§ã\u0082\u0082ã\u0081\u0097ã\u0081\u008fã\u0081\u00afæ\u009c\u0080å°\u008fã\u0082\u0092è¶\u0085ã\u0081\u0088ã\u0081\u009fé\u009a\u009bã\u0081®æ\u00b8\u009bé\u0080\u009få®\u009aæ\u0095°")]
		private float breakSpeedSecondConst;

		[SerializeField]
		[Header("æ\u009c\u0080å¤§ã\u0082\u0082ã\u0081\u0097ã\u0081\u008fã\u0081\u00afæ\u009c\u0080å°\u008fã\u0082\u0092è¶\u0085ã\u0081\u0088ã\u0081\u009fé\u009a\u009bã\u0081«é\u0080\u0086å\u0090\u0091ã\u0081\u008dã\u0081«æ\u0088»ã\u0081\u0099ç\u0082ºã\u0081®å®\u009aæ\u0095°ã\u0080\u0082")]
		[Header("ã\u0081\u009dã\u0081®å\u00a0\u00b4å\u0090\u0088æ\u00b8\u009bé\u0080\u009få\u0080¤ã\u0081«breakSpeedSecondConstã\u0081\u008cå\u0085¥ã\u0082\u008aæ\u0080¥ã\u0083\u0096ã\u0083¬ã\u0083¼ã\u0082­")]
		private float reverseSpeedConst;

		[SerializeField]
		private float breakSpeed;

		[SerializeField]
		private float rotSpeed;

		private bool initialized;

		private float beginRot;

		private float endRot;

		private float wheelWidth;

		private float firstTouchRot;

		private Vector3 firstTouchPos;

		private QuestSelectWheelElement touchTopWheelElement;

		private QuestSelectWheelElement topWheelElement;

		private QuestSelectWheelElement orgWheelElementObj;

		private int _lastSelectedChapterNumber;

		private bool isFirstTop;

		[SerializeField]
		[Header("ã\u0083\u00afã\u0083¼ã\u0083«ã\u0083\u0089ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081«å\u0085¥ã\u0081£ã\u0081¦ã\u0081\u008dã\u0081\u009fé\u009a\u009bã\u0081®ç«\u00a0ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0089ã\u0083­ã\u0083\u0083ã\u0083\u0097å\u009fºæº\u0096Yåº§æ\u00a8\u0099")]
		private float inWorldMapElementBaseY;

		[SerializeField]
		[Header("ã\u0083\u00afã\u0083¼ã\u0083«ã\u0083\u0089ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081«å\u0085¥ã\u0081£ã\u0081¦ã\u0081\u008dã\u0081\u009fé\u009a\u009bã\u0081®ç«\u00a0ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0089ã\u0083­ã\u0083\u0083ã\u0083\u0097delayå\u0080¤")]
		private float inWorldMapElementdelay;

		private CanvasGroup myCanvasGroup;

		public UnityAction<int, QuestSelectWheelElement> onClickWheel;

		private Vector2 defaultChapterNumberPos;

		private Vector2 defaultChapterTitlePos;

		private float openMoveDistance;

		private float closeMoveDistance;

		private Vector2 lineWidth;

		private bool isPlayingChapterScrollByArrowButton;

		public bool isWheel;

		[SerializeField]
		public NewChapterActionTime newChapterDelayTime;

		public float jump;

		public float bounce;

		public float jumpTime;

		public float frameTime;

		public float bounceTime;

		public QuestSelectScene sceneObj
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float ElementsScale => default(float);

		public int lastSelectedChapterNumber => default(int);

		private void Clear()
		{
		}

		public void Initialize()
		{
		}

		public IEnumerator InitializeWheelElements()
		{
			return null;
		}

		private void InitializeQuestGroupList()
		{
		}

		private void Update()
		{
		}

		public void ResetWheel()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public void OnClickMainQuestChapter(QuestSelectWheelChapter clickedChapter)
		{
		}

		public void PlayAreaMapWheelAnim([Optional] UnityAction action)
		{
		}

		public void PlayNewChapterWheelAnimationTop()
		{
		}

		public void PlayNewChapterWheelAnimation([Optional] UnityAction action)
		{
		}

		public void PlayWorldMapWheelAnim([Optional] UnityAction action)
		{
		}

		public void ExitWorldMapWheelAnim([Optional] UnityAction action)
		{
		}

		private void SetTextAlpha(float alpha)
		{
		}

		public void OpenChapterTitle()
		{
		}

		public void CloseChapterTitle()
		{
		}

		private void AnimChapterTitle(bool isBackwards)
		{
		}

		public Sequence NewAnimChapterTitle()
		{
			return null;
		}

		private Sequence NewChapterLightFunction()
		{
			return null;
		}

		private Sequence NewChapterLineFunction()
		{
			return null;
		}

		private Sequence NewChapterNumberTextFunction()
		{
			return null;
		}

		private Sequence NewChapterTitleTextFunction()
		{
			return null;
		}

		public void SetChapterList(List<QSChapterElement> a_chapterList)
		{
		}

		public int CheckMaxChapter()
		{
			return default(int);
		}

		public void SetRotationByChapter(int topChapter, bool isPlaySound = true)
		{
		}

		private void SetRotation(float rot, bool isPlaySound = true)
		{
		}

		public void UpdateAllAchievementLevels()
		{
		}

		public void DisplayChapterNumberAndTitle()
		{
		}

		public void DisplayChapterNumberAndTitleFromMaster(QuestMainGroupElement qmge)
		{
		}

		public QuestSelectWheelElement GetTopChapterElement()
		{
			return null;
		}

		private Vector3 GetNowPoint()
		{
			return default(Vector3);
		}

		public void OnClickChapterLeft()
		{
		}

		public void OnClickChapterRight()
		{
		}

		public void LeftRightArrowsEnable(bool enable)
		{
		}

		public Tweener LeftRightArrowFadeIn(float endValue, float duration)
		{
			return null;
		}

		public void OnClickDifficulty()
		{
		}

		private bool IsDown()
		{
			return default(bool);
		}

		private bool IsFlickLeft()
		{
			return default(bool);
		}

		private bool IsFlickRight()
		{
			return default(bool);
		}

		private bool IsUp()
		{
			return default(bool);
		}

		private bool IsDrag()
		{
			return default(bool);
		}

		private bool IsPress()
		{
			return default(bool);
		}

		private bool IsTouchGuard()
		{
			return default(bool);
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}

		public void NewChapterAnimation()
		{
		}

		public void NewChapterrAnimationTop()
		{
		}

		public void CanvasEnable(float alpha)
		{
		}

		public void SetBgLayerWidth(float width)
		{
		}
	}
}
