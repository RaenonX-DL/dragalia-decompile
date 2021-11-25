using System.Collections.Generic;
using UniRx.Async;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleEffectController : MonoBehaviour
	{
		public GrowthManaCircleScene scene;

		public GrowthManaCircleEffectControllerImpl impl;

		public void PreLoad()
		{
		}

		public void PreLoadForSecond()
		{
		}

		public void OnReleasePoint(GrowthManaCircleManaPieceObject touchedPoint)
		{
		}

		public void OnReleaseAuto(List<GrowthManaCircleManaPieceObject> pointList, List<GrowthManaCircleManaPieceObject> storyReleasePointList, TouchGuardObject touchGuardObject)
		{
		}

		public void OnAutoReleasePieceAndLimiitBreak(GrowthManaCircleManaPieceObject[] pieceObjects, int limitBreak, TouchGuardObject touchGuardObject, bool isUsePlatinumCrystal)
		{
		}

		public void OnReleaseAutoCannotDueToLimit(TouchGuardObject touchGuardObject)
		{
		}

		public void OnReleaseLimit()
		{
		}

		public void PlayReleaseLimitFlash()
		{
		}

		public void ApplyFogSettings()
		{
		}

		public UniTask PlayLevelupFlash()
		{
			return default(UniTask);
		}

		public UniTask PlayAllReleaseFlash()
		{
			return default(UniTask);
		}
	}
}
