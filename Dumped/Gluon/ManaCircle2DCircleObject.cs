using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ManaCircle2DCircleObject : MonoBehaviour
	{
		[SerializeField]
		protected ManaCircle2DCirclePieceObject[] pieceIcons;

		[SerializeField]
		private ManaCircle2DCircleLimitBreakPieceObject limitBreakIcon;

		[SerializeField]
		private Image nextLimitBreakArrow;

		[SerializeField]
		private Image nextCircleArrow;

		[SerializeField]
		protected Image[] lineImages;

		[SerializeField]
		private Sprite enableArrowSprite;

		[SerializeField]
		protected Sprite enableleLineSprite;

		protected int circleIndex;

		protected GrowthManaCircle2DScene scene;

		protected GrowthManaCircleModel model;

		protected List<int> releaseTargetIdList;

		private bool isShowLimitBreakIcon;

		private TouchGuardObject endPieceEffectTouchGuard;

		private int storyPopupCount;

		public void InitCircle(GrowthManaCircle2DScene scene, int circleIndex)
		{
		}

		public void UpdatePiece()
		{
		}

		public virtual void UpdateLine()
		{
		}

		public bool IsReleaseAllPiece()
		{
			return default(bool);
		}

		protected virtual void OnPieceIconPressed(GrowthManaCircleManaPieceData pieceData, ManaCircle2DCirclePieceBase.PieceState state)
		{
		}

		private void OnLimitBreakPieceIconPressed(ManaCircle2DCirclePieceBase.PieceState state)
		{
		}

		private ManaCircle2DCirclePieceObject GetPieceObjectByPieceDataId(int id)
		{
			return null;
		}

		protected void PlayReleasePieceEffect(bool isShowStoryPopup = false)
		{
		}

		protected void PlayAutoReleasePieceEffect(bool isShowStoryPopup, bool isReleaseLimitBreak)
		{
		}

		public void PlayReleaseAllCirclePieceEffect()
		{
		}

		private bool IsChangeGrowMaterialPopup(bool isGrowRelease)
		{
			return default(bool);
		}

		public void PlayReleaseLimitBreakPieceEffect(int storyPopupCount = 0)
		{
		}

		public void PlayReleasePieceAndLimitBreakEffect(GrowthManaCircleManaPieceData[] pieceDataList, int storyPopupCount)
		{
		}

		public static void CreateCharaStoryPopup(int characterId, int storyIndex, int rarity, bool isTemporary, Action OnPopAnimationEnded, Action onCompleted)
		{
		}

		public void AutoReleaseResultAction(GrowthManaCircleManaPieceData[] pieceDataList, int storyPopupCount, bool isReleaseLimitBreak)
		{
		}

		public void PlayUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData, GrowthManaCircleManaPieceData[] pieceDataList, int storyPopupCount, bool isReleaseLimitBreak)
		{
		}

		private void ShowStoryPopups()
		{
		}

		private void ShowGrowEndPopup([Optional] Action action)
		{
		}

		public void SetEnableAllPiece(bool enable)
		{
		}

		public void SetEnablePieceByPieceIndex(int index, bool enable)
		{
		}

		private bool IsRelesableCircleByRarity()
		{
			return default(bool);
		}
	}
}
