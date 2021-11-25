using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectChapterPage : QuestSelectPageBase
	{
		[Serializable]
		public struct FlashPosScaleInfo
		{
			public Vector3 localPos;

			public float localScale;

			public int sortingOrder;
		}

		[SerializeField]
		public Canvas selfCanvas;

		[SerializeField]
		public GameObject uiSelectWheel;

		public GameObject chapterTitleRoot;

		[SerializeField]
		private FlashPosScaleInfo dragonFlashInfo;

		[SerializeField]
		private QuestSelectWheel questSelectWheel;

		public QuestSelectWheelElement topChapterElement;

		private QuestReleasePopup releaseChapterPopup;

		private QuestReleasePopup releaseDifficultyPopup;

		[SerializeField]
		private Transform _mainTrans;

		private FlashPlayer flashPlayerNewChapter;

		public FlashPlayer flashPlayerDragon;

		private bool isNotCloud;

		private bool isDragonAnimation;

		[SerializeField]
		public float iPhoneXMapOffset;

		[SerializeField]
		private EdgeToEdgeFrame edgeToEdgeFrame;

		public List<QSChapterElement> chapterList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform mainTtans => null;

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Initialize()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public void FitSize(float width)
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private void OnDragonAnimationEnd()
		{
		}

		public bool IsDragonAnimation()
		{
			return default(bool);
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private IEnumerator WaitForCloudAnimationComplete()
		{
			return null;
		}

		public void UIOff()
		{
		}

		private IEnumerator MapIconOff(int index)
		{
			return null;
		}

		private void Update()
		{
		}

		public void OnChangeTopChapterElement(QuestMainGroupElement beforeNum, QuestMainGroupElement topNum)
		{
		}

		private IEnumerator DelayChangeMap(QuestMainGroupElement beforeNum, QuestMainGroupElement topNum)
		{
			return null;
		}

		public int GetChengeWorldMapId(QuestMainGroupElement beforeMaster, QuestMainGroupElement afterMaster)
		{
			return default(int);
		}

		private bool IsChageWorldMap(QuestMainGroupElement beforeQmge)
		{
			return default(bool);
		}

		public void OnClickDifficulty()
		{
		}

		public void OnReleasePopupColosed()
		{
		}

		public List<QSChapterElement> GetChapterList()
		{
			return null;
		}

		public void ResetQuestSelectWheel()
		{
		}

		public void SetRotationByChapter(int topChapter, bool isPlaySound = true)
		{
		}

		public int GetLastSelectedChapterNumber()
		{
			return default(int);
		}

		public void DisplayAchievementLevel()
		{
		}

		public void WheelEnable(bool enable)
		{
		}

		public QuestSelectWheelElement GetTopElement()
		{
			return null;
		}

		public QuestSelectWheel GetWheel()
		{
			return null;
		}

		public void PlayWorldMapWheelAnim()
		{
		}

		public void StartWorldMapWheelEnterAnimation()
		{
		}

		public void StartWorldMapWheelExitAnimation()
		{
		}

		public void OnClickMainQuestChapter(int a_chapterNumber, QuestSelectWheelElement a_qswheel)
		{
		}

		public void CanvasActive(bool enable)
		{
		}

		public void OnClickMapIcon()
		{
		}

		public void OpenChapterTitle()
		{
		}

		public void CloseOpenChapterTitle()
		{
		}

		public void SetFlashNewChapterAll()
		{
		}

		private void NewChapterZoomOut()
		{
		}

		private void NewCahpterChangeIcon()
		{
		}

		private void NewChapterUI()
		{
		}

		private void NewChapterFinish()
		{
		}

		private void FlashSetUpNewChapter()
		{
		}

		private void FlashSetCallback(Action action, string label, FlMotionActionTypes type)
		{
		}

		private void FlashPlayNewChapter()
		{
		}

		private Sequence MapMove()
		{
			return null;
		}

		private Sequence ZoomIn()
		{
			return null;
		}

		private Sequence ChangeWorldMapEffect()
		{
			return null;
		}

		private IEnumerator ChangeWorldMapEffectCorutine()
		{
			return null;
		}

		private Sequence ZoomOut()
		{
			return null;
		}

		private void SetPositionZ(Canvas canvas, GameObject target)
		{
		}

		public void CreateDragon()
		{
		}

		public void SetActiveDragon(bool enable)
		{
		}

		private IEnumerator SetActiveDragonCorutine(bool enable)
		{
			return null;
		}

		public void PlayDragonFlash(string str, int delayCount = 0, [Optional] Action action)
		{
		}

		private IEnumerator DelayMethod(Action callback, int delayCount)
		{
			return null;
		}
	}
}
