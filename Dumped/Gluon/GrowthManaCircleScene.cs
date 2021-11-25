using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleScene : SceneBase
	{
		public Camera mainCamera;

		public Camera uiCamera;

		public GrowthManaCircleCameraController cameraController;

		public GrowthManaCircleEffectController effectController;

		public GrowthManaCircleObjectsController objectsController;

		public GrowthManaCircleObjectSettings objectSettings;

		public GrowthManaCircleEffectSettings effectSettings;

		public GrowthManaCircleCameraSettings cameraSettings;

		public GrowthManaCircleSoundController soundController;

		public GrowthManaCircleUICanvas mainCanvas;

		public GrowthManaCircleModel model;

		public float idleTime;

		public bool isMenuOpened;

		private List<GrowthManaCircleManaPieceObject> selectedTouchPointList;

		protected GrowthManaCircleStatusCanvas statusCanvas;

		protected GrowthManaCircleManaPieceDescriptionCanvas pointDescCanvas;

		private int lastTouchPointIndex;

		private GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;

		private bool isGoingSecondCircle;

		public const string prefabDir = "Prefabs/OutGame/Growth/GrowthManaCircle/";

		protected virtual IEnumerator Start()
		{
			return null;
		}

		protected virtual IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public override void OnBeforeLeaving()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected virtual void LateUpdateTask()
		{
		}

		public void OnEndDrag()
		{
		}

		protected virtual void UpdatePointDesc(int targetCircleIndex, int centerTouchPointIndex)
		{
		}

		public void UpdateStatusCanvas()
		{
		}

		public void OnTouchPointClicked(GrowthManaCircleManaPieceObject touchedPoint)
		{
		}

		public void OnReleasePointSuccess(CharaBuildupManaResponse res)
		{
		}

		private void DoReleasePoint()
		{
		}

		public virtual void OnAutotButtonPressed()
		{
		}

		protected void ShowAutoReleasePopup(bool isReleaseSecondCircle = false)
		{
		}

		protected void AutoReleasePieceByPieceData(GrowthManaCircleManaPieceData pieceData, bool isReleaseSecondCircle = false)
		{
		}

		public void AutoReleasePieceByCircleIndex(int circleIndex)
		{
		}

		private void AutoReleaseCommonAction(AutoReleasableAllCirclePointData autoReleasableData, bool isGrowMaterial)
		{
		}

		protected virtual void SendAutoReleaseData(List<GrowthManaCircleManaPieceData> pieceDataList, bool isGrowMaterial)
		{
		}

		public void OnAutoReleasePointSuccess(CharaBuildupManaResponse res)
		{
		}

		protected virtual void DoAutoReleasePoint()
		{
		}

		private void SendAutoReleaseBuildupAndLimitBreakData(AutoReleasableAllCirclePointData autoReleasableData, bool isGrowMaterial, Action<AutoReleasableAllCirclePointData> sendCompleteCallBack)
		{
		}

		private void AutoReleaseResultAction(AutoReleasableAllCirclePointData autoReleasableData)
		{
		}

		protected virtual void UsePlatinumCrystalResultAction(GrowthAwakeResultPop.BeforeData beforeData)
		{
		}

		private void MultiPieceReleaseResultAction(GrowthManaCircleManaPieceData[] manaPieceDatas, int limitBreakCount, bool isUsePlatinumCrystal)
		{
		}

		public void OnMotifClicked(GrowthManaCircleMotifObject.MotifType type, GrowthManaCircleMotifObject touchedMotif)
		{
		}

		private void OnReleaseMotifClicked(GrowthManaCircleMotifObject touchedMotif)
		{
		}

		public void OnLimitBreakSuccess(CharaLimitBreakResponse res)
		{
		}

		private void DoLimitBreak()
		{
		}

		public void GoManaCircleBlankScene(bool isShowTips = true)
		{
		}

		public GrowthManaCircleKnightsStoryPopup CreateCharaStoryPopup([Optional] Action onCompleted)
		{
			return null;
		}

		public GrowthManaCircleKnightsStoryPopup CreateCharaStoryPopup(GrowthManaCircleModel model, int storyIndex, [Optional] Action onCompleted)
		{
			return null;
		}

		public static void CreateReleaseAutoCannotDueToLimitPopup()
		{
		}

		public GrowthManaCircleAllReleaseRewardPopup CreateAllReleasedRewardPopup([Optional] Action callBack)
		{
			return null;
		}

		public GrowthAwakeResultPop CreateUsePlatinumCrystalResultPopup([Optional] Action callBack)
		{
			return null;
		}

		public void OnBackButtonPressed()
		{
		}

		public void SetEnablePointDescCanvas(bool arg)
		{
		}

		public void ForceMoveUpToMaxCircle(float duration)
		{
		}

		public void OnAbilityListButtonPressed()
		{
		}

		public void OnManaCircleMenuButtonPressed()
		{
		}

		public void OnGrowthButtonPressed()
		{
		}

		public void OnAwakeningButtonPressed()
		{
		}

		public void OnListButtonPressed()
		{
		}

		public void StartScreenSaver()
		{
		}

		public void FinishScreenSaver()
		{
		}

		public void AllReleaseForDevelop()
		{
		}

		public void UsePlatinumCrystalPressed()
		{
		}

		public virtual void Reset()
		{
		}

		public void StartTutorial()
		{
		}

		private IEnumerator StartTutorialCoroutine()
		{
			return null;
		}

		private void ShowTutorialPointer()
		{
		}

		public void ShowTutorialFinishWindow()
		{
		}
	}
}
