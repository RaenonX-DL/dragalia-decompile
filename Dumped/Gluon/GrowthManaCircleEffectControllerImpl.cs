using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleEffectControllerImpl : MonoBehaviour
	{
		public GrowthManaCircleScene scene;

		private GrowthManaCircleEffectSettings effectSettings;

		private GrowthManaCircleObjectsController objectsController;

		private FlashPlayer allReleaseFlashPlayer;

		private FlashPlayer releaseLimitFlashPlayer;

		private FlashPlayer levelupFlashPlayer;

		private bool isShowAllReleaseRewardPop;

		private void Start()
		{
		}

		public IEnumerator OnReleasePointCoroutine(GrowthManaCircleManaPieceObject touchedPoint)
		{
			return null;
		}

		private bool IsChangeGrowMaterialPopup(bool isGrowRelease)
		{
			return default(bool);
		}

		private void ShowGrowEndPopup([Optional] Action action)
		{
		}

		public IEnumerator OnReleaseAutoCoroutine(List<GrowthManaCircleManaPieceObject> pointList, List<GrowthManaCircleManaPieceObject> storyReleasePointList, TouchGuardObject touchGuardObject, bool isPlayLimitBreakEffect, bool isUsePlatinumCrystal)
		{
			return null;
		}

		public void OnAutoReleasePieceAndLimitBreak(GrowthManaCircleManaPieceObject[] pieceObjects, int limitBreak, TouchGuardObject touchGuardObject, bool isUsePlatinumCrystal)
		{
		}

		private IEnumerator OnReleasePieceAndLimitBreakByCurrentCircle(List<GrowthManaCircleManaPieceObject> pointList, TouchGuardObject touchGuardObject)
		{
			return null;
		}

		private void CreateCharaStoryPopupFromList(List<GrowthManaCircleManaPieceObject> pointList)
		{
		}

		private void CreateCharaStoryPopupRecursive(List<GrowthManaCircleManaPieceData> pieceList)
		{
		}

		public IEnumerator OnReleaseAutoCannotDueToLimitCoroutine(TouchGuardObject touchGuardObject)
		{
			return null;
		}

		public IEnumerator OnReleaseLimitCoroutine([Optional] List<GrowthManaCircleManaPieceObject> storyReleasePointList, [Optional] TouchGuardObject touchGuardObject)
		{
			return null;
		}

		private IEnumerator DestroyLockObjectCoroutine()
		{
			return null;
		}

		private IEnumerator ReplaceReleaseObjectCoroutine()
		{
			return null;
		}

		public void PreLoadReleaseLimitFlash()
		{
		}

		public IEnumerator PlayReleaseLimitFlashCoroutine()
		{
			return null;
		}

		public IEnumerator OnAllReleasedCoroutine(float delay, bool isUsePlatinumCrystal)
		{
			return null;
		}

		private IEnumerator OnAllReleasedSoundCoroutine(float delay)
		{
			return null;
		}

		private IEnumerator OnAllReleasedCrystalChangeCoroutine(float delay)
		{
			return null;
		}

		private IEnumerator OnAllReleasedManaCircleCoroutine(float delay)
		{
			return null;
		}

		private IEnumerator OnAllReleasedCrystalCoroutine(float delay)
		{
			return null;
		}

		private IEnumerator OnAllReleasedSpaceCoroutine(float delay)
		{
			return null;
		}

		private IEnumerator PlayAllReleaseCameraCoroutine(float delay, bool isUsePlatinumCrystal)
		{
			return null;
		}

		public void PreloadAllReleaseFlash()
		{
		}

		public void PreloadLevelupFlash()
		{
		}

		public IEnumerator PlayAllReleaseFlashCoroutine(float delay, [Optional] Action playEndCallBack)
		{
			return null;
		}

		public IEnumerator PlayLevelupFlashCoroutine(Action playEndCallBack, float delay = 0.5f)
		{
			return null;
		}

		private IEnumerator KickAllReleasedTriggerCoroutine(float delay)
		{
			return null;
		}

		public void ApplyFogSettings()
		{
		}
	}
}
